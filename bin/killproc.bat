@echo off
setlocal
set "proc=%1"
set "dir=%2"
if "%proc%" == "" (
	exit /b 1
)
if "%dir%" == "" (
	exit /b 1
)
powershell -Command "Get-Process %proc% | Where-Object { $_.Path -like '%dir%*' } | ForEach-Object { Stop-Process -Id $_.Id -Force }"
if %ERRORLEVEL% neq 0 (
	exit /b %ERRORLEVEL%
)
exit /b 0