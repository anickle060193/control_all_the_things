#include <Arduino.h>

#include "button.h"
#include "appi.h"

static Button* button;

static void OnStateChanged( Button* b )
{
    APPI::OnPinSet( b->GetPin(), b->GetState() );
}

static void OnInitialize()
{
    APPI::OnPinSet( button->GetPin(), button->GetState() );
}

void setup()
{
    APPI::Setup( OnInitialize );

    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    button = new Button( 12, INPUT_PULLUP );
    button->AttachOnChanged( OnStateChanged );
}

void loop()
{
    button->Update();

    APPI::Loop();
}
