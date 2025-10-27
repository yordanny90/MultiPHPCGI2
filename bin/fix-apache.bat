@echo off
setlocal
echo Preparando Apache
set "conf=%~dp0..\apache_conf\conf\httpd.conf"
echo Actualizando "%conf%"...
call "%~dp0..\config.bat"

set "apachedll=php%ver_php:~0,1%apache2_4.dll"
if not exist "%MULTIPHPDIR%\app\php\%ver_php%\%apachedll%" (
	echo Error: No se encontro el "%apachedll%" en PHP %ver_php%.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define APACHEDLL .*', 'Define APACHEDLL \"%apachedll%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define MULTIPHPDIR .*', 'Define MULTIPHPDIR \"%MULTIPHPDIR:\=/%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define APACHEVER .*', 'Define APACHEVER \"%ver_apache%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define PHPVER .*', 'Define PHPVER \"%ver_php%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define HTDOCS .*', 'Define HTDOCS \"%HTDOCS%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^Define LISTENPORT .*', 'Define LISTENPORT \"%APACHEPORT%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)