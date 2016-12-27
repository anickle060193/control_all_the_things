#ifndef APPI_H
#define APPI_H

#include <Arduino.h>
#include <CmdMessenger.h>

namespace APPI
{
    typedef void (*ConnectedListener)();
    typedef void (*CreateButtonListener)( int pin );
    typedef void (*InitializeListener)();

    void Setup();
    void SetConnectedListener( ConnectedListener listener );
    void SetCreateButtonListener( CreateButtonListener listener );
    void SetInitializeListener( InitializeListener listener );
    void Loop();
    void OnPinSet( int pin, boolean state );
}

#endif
