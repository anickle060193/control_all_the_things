#include "debounce.h"

#define DEBOUNCE_DELAY  ( 50 )

Debounce::Debounce( int pin, int mode )
{
    this->pin = pin;

    pinMode( this->pin, mode );
}

void Debounce::Update( unsigned long now )
{
    boolean reading = !!digitalRead( this->pin );

    if( reading != this->lastState )
    {
        this->lastDebounceTime = now;
    }

    if( now - this->lastDebounceTime > DEBOUNCE_DELAY )
    {
        if( reading != this->state )
        {
            this->state = reading;
            if( this->listener )
            {
                this->listener( this );
            }
        }
    }

    this->lastState = reading;
}
