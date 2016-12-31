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
        public abstract bool Valid( BoardInterface b );

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
                        { "ActionName", "TogglePin" },
                        { "Pin", action.Pin }
                    };
                }
                else if( actionType == typeof( RunCommandBoardAction ) )
                {
                    RunCommandBoardAction action = a as RunCommandBoardAction;
                    return new Setting()
                    {
                        { "ActionName", "RunCommand" },
                        { "FileName", action.FileName },
                        { "Arguments", action.Arguments }
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
                    String actionName = setting.Get<String>( "ActionName" );
                    if( actionName == "SetLed" )
                    {
                        bool setToState = setting.Get<bool>( "SetToState" );
                        return new SetLedBoardAction( setToState );
                    }
                    else if( actionName == "SetPin" )
                    {
                        int pin = setting.Get<int>( "Pin" );
                        bool setToState = setting.Get<bool>( "SetToState" );
                        return new SetPinBoardAction( pin, setToState );
                    }
                    else if( actionName == "TogglePin" )
                    {
                        int pin = setting.Get<int>( "Pin" );
                        return new TogglePinBoardAction( pin );
                    }
                    else if( actionName == "RunCommand" )
                    {
                        String fileName = setting.Get<String>( "FileName" );
                        String arguments = setting.Get<String>( "Arguments" );
                        return new RunCommandBoardAction( fileName, arguments );
                    }
                }
            }
            catch( KeyNotFoundException ) { }
            catch( InvalidCastException ) { }
        
            return null;
        }
    }
}
