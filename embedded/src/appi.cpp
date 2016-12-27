#include "appi.h"

namespace APPI
{
    enum Commands
    {
        Command__Watchdog,
        Command__Connected,
        Command__CreateButton,
        Command__Initialize,
        Command__InitializationFinished,
        Command__Debug,
        Command__SetLed,
        Command__PinSet
    };

    CmdMessenger* messenger = NULL;
    ConnectedListener connectedListener = NULL;
    CreateButtonListener createButtonListener = NULL;
    InitializeListener initializeListener = NULL;

    static void Debug( const char* message )
    {
        messenger->sendCmd( Command__Debug, message );
    }

    static void OnUnknownCommand()
    {
        Debug( "Unknown command." );
    }

    static void OnWatchdogCommand()
    {
        messenger->sendCmd( Command__Watchdog, F( "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD" ) );
    }

    static void OnConnectedCommand()
    {
        if( APPI::connectedListener != NULL )
        {
            APPI::connectedListener();
        }
    }

    static void OnCreateButtonCommand()
    {
        int pin = messenger->readInt32Arg();
        if( APPI::createButtonListener != NULL )
        {
            APPI::createButtonListener( pin );
        }
    }

    static void OnInitializeCommand()
    {
        if( APPI::initializeListener != NULL )
        {
            APPI::initializeListener();
        }

        messenger->sendCmd( Command__InitializationFinished );
    }

    static void OnSetLedCommand()
    {
        boolean enabled = messenger->readBoolArg();
        digitalWrite( LED_BUILTIN, enabled );
    }

    void Setup()
    {
        messenger = new CmdMessenger( Serial );
        messenger->attach( OnUnknownCommand );
        messenger->attach( Command__Watchdog, OnWatchdogCommand );
        messenger->attach( Command__Connected, OnConnectedCommand );
        messenger->attach( Command__CreateButton, OnCreateButtonCommand );
        messenger->attach( Command__Initialize, OnInitializeCommand );
        messenger->attach( Command__SetLed, OnSetLedCommand );
    }

    void SetConnectedListener( ConnectedListener listener )
    {
        APPI::connectedListener = listener;
    }

    void SetCreateButtonListener( CreateButtonListener listener )
    {
        APPI::createButtonListener = listener;
    }

    void SetInitializeListener( InitializeListener listener )
    {
        APPI::initializeListener = listener;
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
