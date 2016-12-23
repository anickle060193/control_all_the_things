#include <Arduino.h>
#include <CmdMessenger.h>

#include "debounce.h"

enum Commands
{
    Command__SetLed
};

CmdMessenger cmdMessenger = CmdMessenger( Serial );

void OnSetLed()
{
    boolean enabled = cmdMessenger.readBoolArg();
    digitalWrite( LED_BUILTIN, enabled );
}

void setup()
{
    Serial.begin( 115200 );

    cmdMessenger.printLfCr();
    cmdMessenger.attach( Command__SetLed, OnSetLed );

    pinMode( LED_BUILTIN, OUTPUT );

    digitalWrite( LED_BUILTIN, LOW );
}

void loop()
{
    cmdMessenger.feedinSerialData();
}
