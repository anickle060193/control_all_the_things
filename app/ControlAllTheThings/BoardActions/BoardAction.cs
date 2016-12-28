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

        public static String ToSetting( BoardAction a )
        {
            if( a != null )
            {
                Type actionType = a.GetType();
                if( actionType == typeof( SetLedBoardAction ) )
                {
                    SetLedBoardAction action = a as SetLedBoardAction;
                    return String.Format( "SetLed {0}", action.SetToState.ToString() );
                }
                else if( actionType == typeof( SetPinBoardAction ) )
                {
                    SetPinBoardAction action = a as SetPinBoardAction;
                    return String.Format( "SetPin {0} {1}", action.Pin, action.SetToState );
                }
                else if( actionType == typeof( TogglePinBoardAction ) )
                {
                    TogglePinBoardAction action = a as TogglePinBoardAction;
                    return String.Format( "TogglePin {0}", action.Pin );
                }
            }

            return "";
        }

        public static BoardAction FromSetting( String setting )
        {
            if( setting != null )
            {
                String[] s = setting.Split( new char[] { ' ' }, 2 );
                if( s.Length == 2 )
                {
                    String actionName = s[ 0 ];
                    String actionSettings = s[ 1 ];

                    if( actionName == "SetLed" )
                    {
                        bool setToState = Boolean.Parse( actionSettings );
                        return new SetLedBoardAction( setToState );
                    }
                    else if( actionName == "SetPin" )
                    {
                        String[] setPinSettings = actionSettings.Split( ' ' );
                        int pin = Int32.Parse( setPinSettings[ 0 ] );
                        bool setToState = Boolean.Parse( setPinSettings[ 1 ] );
                        return new SetPinBoardAction( pin, setToState );
                    }
                    else if( actionName == "TogglePin" )
                    {
                        int pin = Int32.Parse( actionSettings );
                        return new TogglePinBoardAction( pin );
                    }
                }
            }

            return null;
        }
    }
}
