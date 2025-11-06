@echo off
setlocal
set "dir=%1"
set s=15
:start
cls
powershell -Command "Get-Process | Where-Object {$_.Path -like '%dir%*'} | Select-Object Id,Name,Starttime,CPU,Path | Format-Table"
echo Actualizando en %s% segundos...
echo [Ctrl + C] para detener
sleep %s%
goto start
