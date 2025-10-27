@echo off
set "MULTIPHPDIR=%~dp0"
set "MULTIPHPDIR=%MULTIPHPDIR:~2,-1%"

set "HTDOCS=/htdocs"
set "APACHEPORT=8080"

set "ver_nginx=1.27.4"
set "ver_apache=2.4.65-250724"
rem set "ver_apache=2.4.65-250724-Win32-VS17"
set "ver_php=8.2.28"
if exist "%~dp0ver_php.txt" (
	set /p ver_php=<"%~dp0ver_php.txt"
)