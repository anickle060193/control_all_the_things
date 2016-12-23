#ifndef DEBOUNCE_H
#define DEBOUNCE_H

#include "Arduino.h"

static_assert( LOW == false, "Pin state LOW is not equivalent to false." );
static_assert( HIGH == true, "Pin state HIGH is not equivalent to true." );

class Debounce
{
private:
    int pin;
    boolean buttonState = false;
    boolean lastButtonState = false;
    boolean changed = false;
    unsigned long lastDebounceTime = 0;

public:
    Debounce( int pin, int mode );
    void Update( unsigned long now );
    boolean Read();
    boolean Changed();
};

#endif
