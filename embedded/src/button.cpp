#include "button.h"

#define DEBOUNCE_DELAY  ( 50 )

void Button::Update()
{
    unsigned long now = millis();

    bool reading = !!digitalRead( this->pin );

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
