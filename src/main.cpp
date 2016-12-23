#include "Arduino.h"
#include "debounce.h"

#define BUTTON_PIN ( 12 )

Debounce* d;

void setup()
{
    pinMode( LED_BUILTIN, OUTPUT );

    d = new Debounce( BUTTON_PIN, INPUT_PULLUP );
}

void loop()
{
    unsigned long now = millis();

    d->Update( now );

    digitalWrite( LED_BUILTIN, !d->Read() );
}
