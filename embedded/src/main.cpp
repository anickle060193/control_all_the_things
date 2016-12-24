#include <Arduino.h>
#include <CmdMessenger.h>

#include "debounce.h"

enum Commands
{
    Command__Identify,
    Command__Debug,
    Command__SetLed,
    Command__BlinkLed,
    Command__SetPin
};

CmdMessenger messenger = CmdMessenger( Serial );
Debounce* debounce;

void OnUnknownCommand()
{
    messenger.sendCmd( Command__Debug, F( "Unknown command." ) );
}

void OnIdentify()
{
    messenger.sendCmd( Command__Identify, F( "A2D06A28-A5CF-459B-8BD6-0CD5FB3F79AD" ) );
}

void OnSetLed()
{
    boolean enabled = messenger.readBoolArg();
    digitalWrite( LED_BUILTIN, enabled );
}

void OnBlinkLed()
{
    for( int i = 0; i < 3; i++ )
    {
        digitalWrite( LED_BUILTIN, HIGH );
        delay( 500 );
        digitalWrite( LED_BUILTIN, LOW );
        delay( 500 );
    }
}

void OnButtonChanged( Debounce* d )
{
    messenger.sendCmdStart( Command__SetPin );
    messenger.sendCmdArg( d->GetPin() );
    messenger.sendCmdArg( d->GetState() );
    messenger.sendCmdEnd();
}

void AttachCommandCallbacks()
{
    messenger.attach( OnUnknownCommand );
    messenger.attach( Command__Identify, OnIdentify );
    messenger.attach( Command__SetLed, OnSetLed );
    messenger.attach( Command__BlinkLed, OnBlinkLed );
}

void setup()
{
    Serial.begin( 9600 );

    AttachCommandCallbacks();

    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    debounce = new Debounce( 12, INPUT_PULLUP );
    debounce->AttachOnChanged( OnButtonChanged );
}

void loop()
{
    messenger.feedinSerialData();
    debounce->Update( millis() );
}
