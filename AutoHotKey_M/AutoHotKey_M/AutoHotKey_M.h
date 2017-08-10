#include <Windows.h>
#include <iostream>

#define EXPORT extern "C" __declspec(dllexport)

EXPORT int A_ScreenWidth();
EXPORT int A_ScreenHeight();