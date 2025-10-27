@echo off
setlocal
call "%~dp0..\bin\utils.bat"
call "%~dp0compile.bat"
hidec.exe "%~dp0..\MultiPHP.exe"