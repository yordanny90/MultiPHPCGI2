@echo off
setlocal
call "%~dp0utils.bat"
set "ver=%1"
set "install_dir=%~dp0..\app\php\%ver%"
set "php_exe=%install_dir%\php.exe"
set "php_ini=%install_dir%\php.ini"
if "%ver%"=="" (
	echo Debe indicar una version de PHP para configurar.
	exit /b 1
)

echo Instalacion de PHP version %ver%
if not exist "%php_exe%" (
	echo La instalacion no existe.
	exit /b 1
)

echo Modificando php.ini %ver%...
copy /Y "%install_dir%\php.ini-production" "%php_ini%"
if not exist "%php_ini%" (
	echo Error: No se pudo copiar el php.ini.
	exit /b 1
)

call "%~dp0rebuild-phpdir.bat" %php_exe% %php_ini%
if %ERRORLEVEL% neq 0 (
	echo Error: Instalacion invalida.
	exit /b 1
)

rem Habilita opcache solo si no falla
set "ext=opcache"
call "%~dp0phpini_ext.bat" %php_ini% a %ext% %php_exe%
if %ERRORLEVEL% neq 0 (
	call "%~dp0phpini_ext.bat" %php_ini% i %ext%
	echo Warning: No se pudo habilitar la extension %ext%.
)
rem Habilita bz2 solo si no falla
set "ext=bz2"
call "%~dp0phpini_ext.bat" %php_ini% a %ext% %php_exe%
if %ERRORLEVEL% neq 0 (
	call "%~dp0phpini_ext.bat" %php_ini% i %ext%
	echo Warning: No se pudo habilitar la extension %ext%.
)

rem Prueba final de php
call "%~dp0phptest.bat" %php_exe% %php_ini%
if %ERRORLEVEL% neq 0 (
	exit /b %ERRORLEVEL%
)

exit /b 0