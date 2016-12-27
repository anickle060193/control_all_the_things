#include <Arduino.h>

#include "button.h"
#include "appi.h"

#define MAX_BUTTONS     ( 20 )

static Button* buttons[ MAX_BUTTONS ];
static int buttonCount = 0;

static void OnStateChanged( Button* b )
{
    APPI::OnPinSet( b->GetPin(), b->GetState() );
}

static void OnConnected()
{
    for( int i = 0; i < buttonCount; i++ )
    {
        delete( buttons[ i ] );
        buttons[ i ] = NULL;
    }

    buttonCount = 0;
}

static void OnCreateButton( int pin )
{
    if( buttonCount < MAX_BUTTONS )
    {
        Button* b = new Button( pin );
        b->SetStateChangedListener( OnStateChanged );
        buttons[ buttonCount ] = b;
        buttonCount++;
    }
}

static void OnInitialize()
{
    for( int i = 0; i < buttonCount; i++ )
    {
        Button* b = buttons[ i ];
        APPI::OnPinSet( b->GetPin(), b->GetState() );
    }
}

void setup()
{
    pinMode( LED_BUILTIN, OUTPUT );
    digitalWrite( LED_BUILTIN, LOW );

    Serial.begin( 9600 );

    APPI::Setup();
    APPI::SetConnectedListener( OnConnected );
    APPI::SetCreateButtonListener( OnCreateButton );
    APPI::SetInitializeListener( OnInitialize );
}

void loop()
{
    for( int i = 0; i < buttonCount; i++ )
    {
        buttons[ i ]->Update();
    }

    APPI::Loop();
}
