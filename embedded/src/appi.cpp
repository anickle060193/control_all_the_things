#include "appi.h"

namespace APPI
{
    enum Commands
    {
        Command__Watchdog,
        Command__Initialize,
        Command__InitializationFinished,
        Command__Debug,
        Command__SetLed,
        Command__PinSet
    };

    CmdMessenger* messenger;
    Initializer init;

    static void Debug( const char* message )
    {
        messenger->sendCmd( Command__Debug, message );
    }

    static void OnUnknownCommand()
    {
        Debug( "Unknown command." );
    }

    static void OnWatchdog()
    {
        messenger->sendCmd( Command__Watchdog, F( "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD" ) );
    }

    static void OnInitialize()
    {
        if( init != NULL )
        {
            init();
        }
        messenger->sendCmd( Command__InitializationFinished );
    }

    static void OnSetLed()
    {
        boolean enabled = messenger->readBoolArg();
        digitalWrite( LED_BUILTIN, enabled );
    }

    void Setup( Initializer init )
    {
        APPI::init = init;

        Serial.begin( 9600 );

        messenger = new CmdMessenger( Serial );
        messenger->attach( OnUnknownCommand );
        messenger->attach( Command__Watchdog, OnWatchdog );
        messenger->attach( Command__Initialize, OnInitialize );
        messenger->attach( Command__SetLed, OnSetLed );
    }

    void Loop()
    {
        messenger->feedinSerialData();
    }

    void OnPinSet( int pin, boolean state )
    {
        messenger->sendCmdStart( Command__PinSet );
        messenger->sendCmdArg( pin );
        messenger->sendCmdArg( state );
        messenger->sendCmdEnd();
    }
}
