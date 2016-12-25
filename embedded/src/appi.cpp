#include "appi.h"

enum Commands
{
    Command__Watchdog,
    Command__Debug,
    Command__SetLed,
    Command__PinSet
};

static CmdMessenger* messenger;

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

static void OnSetLed()
{
    boolean enabled = messenger->readBoolArg();
    digitalWrite( LED_BUILTIN, enabled );
}

void APPI_Setup()
{
    Serial.begin( 9600 );

    messenger = new CmdMessenger( Serial );
    messenger->attach( OnUnknownCommand );
    messenger->attach( Command__Watchdog, OnWatchdog );
    messenger->attach( Command__SetLed, OnSetLed );
}

void APPI_Loop()
{
    messenger->feedinSerialData();
}

void APPI_OnPinSet( int pin, boolean state )
{
    messenger->sendCmdStart( Command__PinSet );
    messenger->sendCmdArg( pin );
    messenger->sendCmdArg( state );
    messenger->sendCmdEnd();
}
