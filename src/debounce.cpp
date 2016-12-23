#include "debounce.h"

#define DEBOUNCE_DELAY  ( 50 )

Debounce::Debounce( int pin, int mode )
{
    this->pin = pin;

    pinMode( this->pin, mode );
}

void Debounce::Update( unsigned long now )
{
    int reading = digitalRead( this->pin );

    if( reading != this->lastButtonState )
    {
        this->lastDebounceTime = now;
    }

    if( now - this->lastDebounceTime > DEBOUNCE_DELAY )
    {
        if( reading != this->buttonState )
        {
            this->buttonState = reading;
        }
    }

    this->lastButtonState = reading;
}

int Debounce::Read()
{
    return this->buttonState;
}
