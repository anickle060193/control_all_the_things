#include "appi.h"

enum Commands
{
    Command__Identify,
    Command__Debug,
    Command__SetLed,
    Command__BlinkLed,
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

static void OnIdentify()
{
    messenger->sendCmd( Command__Identify, F( "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD" ) );
}

static void OnSetLed()
{
    boolean enabled = messenger->readBoolArg();
    digitalWrite( LED_BUILTIN, enabled );
}

static void OnBlinkLed()
{
    for( int i = 0; i < 3; i++ )
    {
        digitalWrite( LED_BUILTIN, HIGH );
        delay( 500 );
        digitalWrite( LED_BUILTIN, LOW );
        delay( 500 );
    }
}

void APPI_Setup()
{
    Serial.begin( 9600 );

    messenger = new CmdMessenger( Serial );
    messenger->attach( OnUnknownCommand );
    messenger->attach( Command__Identify, OnIdentify );
    messenger->attach( Command__SetLed, OnSetLed );
    messenger->attach( Command__BlinkLed, OnBlinkLed );
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
