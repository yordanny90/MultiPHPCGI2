@echo off
set "MULTIPHPDIR=%~dp0"
set "MULTIPHPDIR=%MULTIPHPDIR:~2,-1%"

set "HTDOCS=%MULTIPHPDIR%\htdocs"
set "PORT=80"
set "SSLPORT=443"
set "APACHEPORT=8080"

set "ver_nginx=1.27.4"
set "ver_apache=2.4.65-250724"
set "ver_php=8.2.28"
if exist "%~dp0ver_php.txt" (
	set /p ver_php=<"%~dp0ver_php.txt"
)