@echo off
setlocal
set php_exe=%1
set php_ini=%2
if not exist "%php_exe%" (
	echo El archivo "%php_exe%" no existe.
	exit /b 1
)
if not exist "%php_ini%" (
	echo El archivo "%php_ini%" no existe.
	exit /b 1
)

for /f "tokens=*" %%i in ('powershell -Command "& { & '%php_exe%' -c '%php_ini%' -m 2>&1 | Select-String 'warning|error' }"') do (
	echo Error: Se detecto un warning o error al comprobar PHP.
	echo %%i
	exit /b 1
)
exit /b 0