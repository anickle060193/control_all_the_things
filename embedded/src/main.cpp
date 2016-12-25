#include <Arduino.h>

#include "debounce.h"
#include "appi.h"

static Debounce* debounce;

static void OnStateChanged( Debounce* d )
{
    APPI::OnPinSet( d->GetPin(), d->GetState() );
}

static void OnInitialize()
{
    APPI::OnPinSet( debounce->GetPin(), debounce->GetState() );
}

void setup()
{
    APPI::Setup( OnInitialize );

    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    debounce = new Debounce( 12, INPUT_PULLUP );
    debounce->AttachOnChanged( OnStateChanged );
}

void loop()
{
    APPI::Loop();
    debounce->Update( millis() );
}
