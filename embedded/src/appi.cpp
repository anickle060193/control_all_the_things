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
        Command__SetPinMode,
        Command__SetPin,
        Command__TogglePin,
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
        if( connectedListener != NULL )
        {
            connectedListener();
        }
    }

    static void OnCreateButtonCommand()
    {
        int pin = messenger->readInt32Arg();
        if( createButtonListener != NULL )
        {
            createButtonListener( pin );
        }
    }

    static void OnInitializeCommand()
    {
        if( initializeListener != NULL )
        {
            initializeListener();
        }
        messenger->sendCmd( Command__InitializationFinished );
    }

    static void OnSetLedCommand()
    {
        boolean enabled = messenger->readBoolArg();
        digitalWrite( LED_BUILTIN, enabled );
    }

    static void OnSetPinModeCommand()
    {
        int pin = messenger->readInt32Arg();
        int mode = messenger->readInt32Arg();
        pinMode( pin, mode );
    }

    static void OnSetPinCommand()
    {
        int pin = messenger->readInt32Arg();
        bool state = messenger->readBoolArg();
        digitalWrite( pin, state );
    }

    static void OnTogglePinCommand()
    {
        int pin = messenger->readInt32Arg();
        bool state = digitalRead( pin );
        digitalWrite( pin, !state );
    }

    void Setup()
    {
        Serial.begin( 9600 );
        unsigned long start = millis();
        while( !Serial && ( millis() - start < 5000 ) ) { }

        messenger = new CmdMessenger( Serial );
        messenger->attach( OnUnknownCommand );
        messenger->attach( Command__Watchdog, OnWatchdogCommand );
        messenger->attach( Command__Connected, OnConnectedCommand );
        messenger->attach( Command__CreateButton, OnCreateButtonCommand );
        messenger->attach( Command__Initialize, OnInitializeCommand );
        messenger->attach( Command__SetLed, OnSetLedCommand );
        messenger->attach( Command__SetPinMode, OnSetPinModeCommand );
        messenger->attach( Command__SetPin, OnSetPinCommand );
        messenger->attach( Command__TogglePin, OnTogglePinCommand );
    }

    void Loop()
    {
        messenger->feedinSerialData();
    }

    void SetConnectedListener( ConnectedListener listener )
    {
        connectedListener = listener;
    }

    void SetCreateButtonListener( CreateButtonListener listener )
    {
        createButtonListener = listener;
    }

    void SetInitializeListener( InitializeListener listener )
    {
        initializeListener = listener;
    }

    void OnPinSet( int pin, boolean state )
    {
        messenger->sendCmdStart( Command__PinSet );
        messenger->sendCmdArg( pin );
        messenger->sendCmdArg( state );
        messenger->sendCmdEnd();
    }
}
