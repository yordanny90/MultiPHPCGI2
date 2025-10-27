@echo off
setlocal
call "%~dp0..\bin\utils.bat"
call killproc.bat MultiPHP
del "%~dp0..\MultiPHP.exe"
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /win32icon:"%~dp0../app.ico" /t:winexe "/out:%~dp0..\MultiPHP.exe" "%~dp0TrayIcon.cs"