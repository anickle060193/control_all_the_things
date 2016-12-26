#ifndef BUTTON_H
#define BUTTON_H

#include "Arduino.h"

static_assert( LOW == false, "Pin state LOW is not equivalent to false." );
static_assert( HIGH == true, "Pin state HIGH is not equivalent to true." );


class Button
{
    typedef void (*OnChanged)( Button* );

private:
    int pin;
    bool state = false;
    bool lastState = false;
    OnChanged listener = NULL;
    unsigned long lastDebounceTime = 0;

public:
    Button( int pin, int mode )
    {
        this->pin = pin;
        pinMode( this->pin, INPUT_PULLUP );
    }

    int GetPin() { return this-> pin; }
    bool GetState() { return !this->state; }
    void AttachOnChanged( OnChanged listener ) { this->listener = listener; }

    void Update();
};

#endif
