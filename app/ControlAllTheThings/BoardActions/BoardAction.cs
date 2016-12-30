using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAllTheThings.BoardActions
{
    public abstract class BoardAction
    {
        public abstract void Perform( BoardInterface b );

        public static Setting ToSetting( BoardAction a )
        {
            if( a != null )
            {
                Type actionType = a.GetType();
                if( actionType == typeof( SetLedBoardAction ) )
                {
                    SetLedBoardAction action = a as SetLedBoardAction;
                    return new Setting()
                    {
                        { "ActionName", "SetLed" },
                        { "SetToState", action.SetToState }
                    };
                }
                else if( actionType == typeof( SetPinBoardAction ) )
                {
                    SetPinBoardAction action = a as SetPinBoardAction;
                    return new Setting()
                    {
                        { "ActionName", "SetPin" },
                        { "Pin", action.Pin },
                        { "SetToState", action.SetToState }
                    };
                }
                else if( actionType == typeof( TogglePinBoardAction ) )
                {
                    TogglePinBoardAction action = a as TogglePinBoardAction;
                    return new Setting()
                    {
                        { "ActionName", "SetPin" },
                        { "Pin", action.Pin }
                    };
                }
            }
            return null;
        }
        
        public static BoardAction FromSetting( Setting setting )
        {
            try
            {
                if( setting != null )
                {
                    String actionName = (String)setting[ "ActionName" ];
                    if( actionName == "SetLed" )
                    {
                        bool setToState = (bool)setting[ "SetToState" ];
                        return new SetLedBoardAction( setToState );
                    }
                    else if( actionName == "SetPin" )
                    {
                        int pin = (int)setting[ "Pin" ];
                        bool setToState = (bool)setting[ "SetToState" ];
                        return new SetPinBoardAction( pin, setToState );
                    }
                    else if( actionName == "TogglePin" )
                    {
                        int pin = (int)setting[ "Pin" ];
                        return new TogglePinBoardAction( pin );
                    }
                }
            }
            catch( KeyNotFoundException ) { }
            catch( InvalidCastException ) { }
        
            return null;
        }
    }
}
