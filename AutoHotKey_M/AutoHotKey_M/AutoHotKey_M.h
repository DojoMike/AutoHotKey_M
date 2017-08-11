#include <Windows.h>
#include <iostream>

#define EXPORT extern "C" __declspec(dllexport)

// Built-in (A_*) variables
EXPORT const wchar_t * A_AppData();
EXPORT const wchar_t * A_AppDataCommon();
EXPORT const wchar_t * A_ComputerName();
EXPORT const wchar_t * A_Desktop();
EXPORT const wchar_t * A_DesktopCommon();
EXPORT bool A_Is64bitOS();
EXPORT bool A_IsAdmin();
EXPORT const wchar_t * A_Language();
EXPORT const wchar_t * A_MyDocuments();
EXPORT const wchar_t * A_ProgramFiles();
EXPORT const wchar_t * A_Programs();
EXPORT const wchar_t * A_ProgramsCommon();
EXPORT int A_ScreenHeight();
EXPORT int A_ScreenWidth();
EXPORT const wchar_t * A_StartMenu();
EXPORT const wchar_t * A_StartMenuCommon();
EXPORT const wchar_t * A_Startup();
EXPORT const wchar_t * A_StartupCommon();
EXPORT const wchar_t * A_UserName();
EXPORT const wchar_t * A_WinDir();