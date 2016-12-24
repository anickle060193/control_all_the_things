#ifndef DEBOUNCE_H
#define DEBOUNCE_H

#include "Arduino.h"

static_assert( LOW == false, "Pin state LOW is not equivalent to false." );
static_assert( HIGH == true, "Pin state HIGH is not equivalent to true." );


class Debounce
{
    typedef void (*OnChanged)( Debounce* );

private:
    int pin;
    boolean state = false;
    boolean lastState = false;
    OnChanged listener = NULL;
    unsigned long lastDebounceTime = 0;

public:
    Debounce( int pin, int mode );

    int GetPin() { return this-> pin; }
    boolean GetState() { return !this->state; }
    void AttachOnChanged( OnChanged listener ) { this->listener = listener; }

    void Update( unsigned long now );
};

#endif
