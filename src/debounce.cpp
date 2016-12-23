#include "debounce.h"

#define DEBOUNCE_DELAY  ( 50 )

Debounce::Debounce( int pin, int mode )
{
    this->pin = pin;

    pinMode( this->pin, mode );
}

void Debounce::Update( unsigned long now )
{
    this->changed = false;

    boolean reading = !!digitalRead( this->pin );

    if( reading != this->lastButtonState )
    {
        this->lastDebounceTime = now;
    }

    if( now - this->lastDebounceTime > DEBOUNCE_DELAY )
    {
        if( reading != this->buttonState )
        {
            this->buttonState = reading;
            this->changed = true;
        }
    }

    this->lastButtonState = reading;
}

boolean Debounce::Read()
{
    return this->buttonState;
}

boolean Debounce::Changed()
{
    return this->changed;
}
