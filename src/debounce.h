#ifndef DEBOUNCE_H
#define DEBOUNCE_H

#include "Arduino.h"

class Debounce
{
private:
    int pin;
    int buttonState = LOW;
    int lastButtonState = LOW;
    unsigned long lastDebounceTime = 0;

public:
    Debounce( int pin, int mode );
    void Update( unsigned long now );
    int Read();
};

#endif
