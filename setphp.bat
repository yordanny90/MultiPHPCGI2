@echo off
call "%~dp0config.bat"
echo Version actual: "%ver_php%"
if "%1" == "0" (
	if exist "%~dp0ver_php.txt" (
		@rm "%~dp0ver_php.txt"
	)
	echo Ha asignado la version por defecto
	exit /b
)
if "%1" == "" (
	echo Debe ingresar una version de PHP para guardarla
	echo Ingrese 0 para asignar la version por defecto
	exit /b %ERRORLEVEL%
)
echo %1> "%~dp0ver_php.txt"
