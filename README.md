# Drag And Drop Multiple Files for Linux (on Windows 10)
Drag and Drop multiple files into the file list, and hit Execute to run a linux command under Windows 10 using wsl.exe

![Program interface](Screenshot.png)

Requires .net 4.7

Remembers the path to the exe and the parameters.

I wrote this just so I didn't have to keep typing out multiple paths to files on the Linux shell in Windows 10.

You will need the Windows subsystem for Linux installed, along with a Linux distribution from the Windows Store. eg Ubuntu, Debian, SUSE etc

If you get an error about file not found, tick the 'Disable 64 bit file redirection' box, since wsl.exe doesn't appear in SYSWOW64.
