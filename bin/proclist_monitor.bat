@echo off
setlocal
set "dir=%1"
:start
cls
powershell -Command "Get-Process | Where-Object {$_.Path -like '%dir%*'} | Select-Object Id,Name,Starttime,CPU,Path | Format-Table"
sleep 10
goto start
