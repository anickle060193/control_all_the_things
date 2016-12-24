#include <Arduino.h>

#include "debounce.h"
#include "appi.h"

static Debounce* debounce;

static void OnStateChanged( Debounce* d )
{
    APPI_OnPinSet( d->GetPin(), d->GetState() );
}

void setup()
{
    APPI_Setup();

    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    debounce = new Debounce( 12, INPUT_PULLUP );
    debounce->AttachOnChanged( OnStateChanged );
}

void loop()
{
    APPI_Loop();
    debounce->Update( millis() );
}
