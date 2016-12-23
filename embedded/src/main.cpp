#include "Arduino.h"
#include "debounce.h"

#define BUTTON_PIN ( 12 )

Debounce* d;

void setup()
{
    Serial.begin( 9600 );
    pinMode( LED_BUILTIN, OUTPUT );

    d = new Debounce( BUTTON_PIN, INPUT_PULLUP );
}

void loop()
{
    unsigned long now = millis();

    d->Update( now );

    boolean b = !d->Read();
    digitalWrite( LED_BUILTIN, b );

    if( d->Changed() )
    {
        Serial.println( b );
    }
}
