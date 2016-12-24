#include <Arduino.h>
#include <CmdMessenger.h>

#include "debounce.h"

enum Commands
{
    Command__Acknowledge,
    Command__SetLed,
    Command__SetPin
};

CmdMessenger cmdMessenger = CmdMessenger( Serial );
Debounce* debounce;

void OnSetLed()
{
    boolean enabled = cmdMessenger.readBoolArg();
    digitalWrite( LED_BUILTIN, enabled );
}

void OnButtonChanged( Debounce* d )
{
    cmdMessenger.sendCmdStart( Command__SetPin );
    cmdMessenger.sendCmdArg( d->GetPin() );
    cmdMessenger.sendCmdArg( d->GetState() );
    cmdMessenger.sendCmdEnd();
}

void setup()
{
    Serial.begin( 115200 );

    cmdMessenger.printLfCr();
    cmdMessenger.attach( Command__SetLed, OnSetLed );
    cmdMessenger.sendCmd( Command__Acknowledge, "Board has started!" );

    pinMode( LED_BUILTIN, OUTPUT );

    digitalWrite( LED_BUILTIN, LOW );

    debounce = new Debounce( 12, INPUT_PULLUP );
    debounce->AttachOnChanged( OnButtonChanged );
}

void loop()
{
    cmdMessenger.feedinSerialData();
    debounce->Update( millis() );
}
