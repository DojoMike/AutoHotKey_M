#include <Windows.h>
#include "AutoHotKey_M.h"

EXPORT int A_ScreenWidth()
{
	LPRECT r = new RECT();
	GetWindowRect(GetDesktopWindow(), r);
	int width = r->right;
	delete r;
	return width;
}

EXPORT int A_ScreenHeight()
{
	LPRECT r = new RECT();
	GetWindowRect(GetDesktopWindow(), r);
	int height = r->bottom;
	delete r;
	return height;
}