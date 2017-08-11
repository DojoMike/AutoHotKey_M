#include <Windows.h>
#include "AutoHotKey_M.h"
#include <shlobj.h>

EXPORT const wchar_t * A_AppData()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_APPDATA, FALSE);
	return pf;
}
EXPORT const wchar_t * A_AppDataCommon()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_COMMON_APPDATA, FALSE);
	return pf;
}
EXPORT const wchar_t * A_ComputerName()
{
	wchar_t infoBuf[32767];	// This number came from an example on MSDN
	DWORD bufCharCount = 32767;
	GetComputerName(infoBuf, &bufCharCount);
	return infoBuf;
}
EXPORT const wchar_t * A_Desktop()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_DESKTOP, FALSE);
	return pf;
}
EXPORT const wchar_t * A_DesktopCommon()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_COMMON_DESKTOPDIRECTORY, FALSE);
	return pf;
}
EXPORT bool A_Is64bitOS()
{
	PBOOL result = new BOOL(false);
	IsWow64Process(GetCurrentProcess(), result);
	return result;
}
EXPORT bool A_IsAdmin()
{
	// Code adapted from https://github.com/Lexikos/AutoHotkey_L/blob/72f605d6ce0a769a6d3998a3f5286fed99fb8a42/source/script_autoit.cpp
	bool result = false;
	SC_HANDLE h = OpenSCManager(NULL, NULL, SC_MANAGER_LOCK);
	if (h)
	{
		SC_LOCK lock = LockServiceDatabase(h);
		if (lock)
		{
			UnlockServiceDatabase(lock);
			result = true; // Current user is admin.
		}
		else
		{
			DWORD lastErr = GetLastError();
			if (lastErr == ERROR_SERVICE_DATABASE_LOCKED)
				result = true; // Current user is admin.
		}
		CloseServiceHandle(h);
	}
	return result;
}
EXPORT const wchar_t * A_Language()
{
	wchar_t infoBuf[32767];
	GetUserDefaultLocaleName(infoBuf, 32767);
	return infoBuf;
}
EXPORT const wchar_t * A_MyDocuments()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_MYDOCUMENTS, FALSE);
	return pf;
}
EXPORT const wchar_t * A_ProgramFiles()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_PROGRAM_FILES, FALSE);
	return pf;
}
EXPORT const wchar_t * A_Programs()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_PROGRAMS, FALSE);
	return pf;
}
EXPORT const wchar_t * A_ProgramsCommon()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_COMMON_PROGRAMS, FALSE);
	return pf;
}
EXPORT int A_ScreenHeight()
{
	// Declare variables
	RECT desktop;
	const HWND hDesktop = GetDesktopWindow();

	// Load the size of the screen into the RECT structure
	GetWindowRect(hDesktop, &desktop);

	// Return the height
	return desktop.bottom;
}
EXPORT int A_ScreenWidth()
{
	// Declare variables
	RECT desktop;
	const HWND hDesktop = GetDesktopWindow();

	// Load the size of the screen into the RECT structure
	GetWindowRect(hDesktop, &desktop);

	// Return the width
	return desktop.right;
}
EXPORT const wchar_t * A_StartMenu()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_STARTMENU, FALSE);
	return pf;
}
EXPORT const wchar_t * A_StartMenuCommon()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_COMMON_STARTMENU, FALSE);
	return pf;
}
EXPORT const wchar_t * A_Startup()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_STARTUP, FALSE);
	return pf;
}
EXPORT const wchar_t * A_StartupCommon()
{
	wchar_t pf[32767];
	SHGetSpecialFolderPath(0, pf, CSIDL_COMMON_STARTUP, FALSE);
	return pf;
}
EXPORT const wchar_t * A_UserName()
{
	wchar_t infoBuf[32767];	// This number came from an example on MSDN
	DWORD bufCharCount = 32767;
	GetUserName(infoBuf, &bufCharCount);
	return infoBuf;
}
EXPORT const wchar_t * A_WinDir()
{
	wchar_t infoBuf[32767];	// This number came from an example on MSDN
	GetWindowsDirectory(infoBuf, 32767);
	return infoBuf;
}