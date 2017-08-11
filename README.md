# AutoHotKey_M

This project is a Windows DLL loosely based on AutoHotKey and its variants.  It has one major difference from AutoHotKey_L or even AutoHotKey_H: it's not a language.  I'm doing it this way because what AHK does best (IMO) is automation and hotkeys - the original developer named it well (lol).  In fact, I haven't seen a better tool on Windows for automation or hotkeys - *including Microsoft's own UI Automation framework*.  But it adds to this amazing API a ton of completely unnecessary stuff that other languages can already do, and some do better.  This is because it was invented as a new language - so of course they wanted it to be capable of doing GUIs, strings, native code interop, math(s), regular expressions, and all that.  But their forum doesn't compare to the richness of the communities behind other languages, and sadly the new language got a bad rap as being all about cheating at video games.  As a result, few developers have ever heard of it, and even fewer know how to use it to its full potential.  This means that apart from guys like me (who use it constantly) nobody's building new libraries (or even wrappers for existing libraries) in AHK.  And don't get me started on its syntax.  I _really_ wanted to have access to AHK's functionality, without being forced to use this mixed-up little language that (IMO) is holding the project back.

## Game Plan / Roadmap

Currently the project has 3 main components:
* The native DLL that actually implements AHK functionality; this can be used from languages like C, C++, Python, maybe Java (if Java can use DLLs - it's been ages since I've even looked at that language though), and any other language that can use Windows DLLs.
* A second DLL for running the code from .NET languages (C#, VB, C++, F#, IronPython, PowerShell, JScript.NET etc.).  This is where we're _really_ opening up AutoHotKey to the rest of the Windows world.
* A test program for the DLLs; this will also give you examples, until this first stage of development is done.

Once that's done, we'll basically have a beta.  Here's my plan for moving it to a stable release:
* Create an AHK script that does everything the test C# project does.  This is so we can catch any differences in behavior between AHK_L and AHK_M that we missed during development.
* Creating programs that use that use the new libraries for further debugging.
* Write the documentation and let people know what we got goin' on here!

## Sound like fun?  Feel free to contribute!

With a project as big as this, I'm totally down for teaming up.  I'm specifically looking for:
* C++ developers to help with the native DLL
* C# developers to help with the .NET class library
* Anyone who wants to help test the DLLs.

## License

I'm pretty sure I'm gonna have to Google AHK's license, and put that here.  Personally I would WTFPL everything, but since this is based off someone else's work we gotta respect their license.  I'll have that info up soon.