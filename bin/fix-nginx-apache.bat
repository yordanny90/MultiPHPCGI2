@echo off
setlocal

call "%~dp0..\config.bat"

echo Preparando NGINX
set "conf=%MULTIPHPDIR%\nginx_conf\conf\sites-enabled\apache-default.conf"
echo Actualizando "%conf%"...

powershell -Command "(Get-Content '%conf%') -replace '^(\s*set \$htdocs) .*', '$1 \"%HTDOCS:\=/%\";' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(\s*set \$apacheport) .*', '$1 %APACHEPORT%;' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(\s*listen) \S* (default_server;.*)', '$1 %PORT% $2' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(\s*listen) \S* (ssl default_server;.*)', '$1 %SSLPORT% $2' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)

echo Preparando Apache
set "conf=%MULTIPHPDIR%\apache_conf\conf\httpd.conf"
echo Actualizando "%conf%"...

set verXphp=%ver_php:~0,1%
set "apachedll=php%verXphp%apache2_4.dll"
if not exist "%MULTIPHPDIR%\app\php\%ver_php%\%apachedll%" (
	echo Error: No se encontro el "%apachedll%" en PHP %ver_php%.
	exit /b %ERRORLEVEL%
)
set phpmod=php_module
if "%verXphp%" == "5" (
	set phpmod=php5_module
)
if "%verXphp%" == "7" (
	set phpmod=php7_module
)
powershell -Command "(Get-Content '%conf%') -replace '^(LoadModule php.?_module )(.*)', 'LoadModule %phpmod% $2' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define APACHEDLL) .*', '$1 \"%apachedll%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define MULTIPHPDIR) .*', '$1 \"%MULTIPHPDIR:\=/%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define APACHEVER) .*', '$1 \"%ver_apache%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define PHPVER) .*', '$1 \"%ver_php%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define HTDOCS) .*', '$1 \"%HTDOCS:\=/%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)
powershell -Command "(Get-Content '%conf%') -replace '^(Define LISTENPORT) .*', '$1 \"%APACHEPORT%\"' | Set-Content '%conf%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo actualizar.
	exit /b %ERRORLEVEL%
)

if not exist "%HTDOCS%" (
	mkdir "%HTDOCS%"
	if %ERRORLEVEL% neq 0 (
		echo Error: No se pudo crear la carpeta "%HTDOCS%".
		exit /b %ERRORLEVEL%
	)
	if not exist "%HTDOCS%\index.html" if not exist "%HTDOCS%\index.php" (
		echo ^<?php > "%HTDOCS%\index.php"
		echo ^phpinfo(^); >> "%HTDOCS%\index.php"
	)
)
