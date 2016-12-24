#ifndef APPI_H
#define APPI_H

#include <Arduino.h>
#include <CmdMessenger.h>

void APPI_Setup();
void APPI_Loop();
void APPI_SetPin( int pin, boolean state );

#endif
