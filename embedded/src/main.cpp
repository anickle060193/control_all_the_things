#include <Arduino.h>

#include "button.h"
#include "appi.h"
#include "list.h"

static List<Button*> buttons = List<Button*>();

static void OnStateChanged( Button* b )
{
    APPI::OnPinSet( b->GetPin(), b->GetState() );
}

static void OnInitialize()
{
    for( int i = 0; i < buttons.Count(); i++ )
    {
        Button* b = buttons[ i ];
        APPI::OnPinSet( b->GetPin(), b->GetState() );
    }
}

void setup()
{
    APPI::Setup( OnInitialize );

    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    Button* button12 = new Button( 12, INPUT_PULLUP );
    button12->AttachOnChanged( OnStateChanged );
    buttons.Add( button12 );

    Button* button11 = new Button( 11, INPUT_PULLUP );
    button11->AttachOnChanged( OnStateChanged );
    buttons.Add( button11 );
}

void loop()
{
    for( int i = 0; i < buttons.Count(); i++ )
    {
        buttons[ i ]->Update();
    }

    APPI::Loop();
}
