#ifndef APPI_H
#define APPI_H

#include <Arduino.h>
#include <CmdMessenger.h>

namespace APPI
{
    typedef void (*Initializer)();

    void Setup( Initializer init = NULL );
    void Loop();
    void OnPinSet( int pin, boolean state );
}

#endif
