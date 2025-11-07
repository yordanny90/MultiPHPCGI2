@echo off
call "%~dp0config.bat"
call "%~dp0bin\cert_generate.bat"
if %ERRORLEVEL% neq 0 (
	goto error
)
echo on
call "%~dp0bin\install-nginx.bat" %ver_nginx%
if %ERRORLEVEL% neq 0 (
	goto error
)
call "%~dp0bin\install-apache.bat" %ver_apache%
if %ERRORLEVEL% neq 0 (
	goto error
)
call "%~dp0bin\install-php.bat" %ver_php%
if %ERRORLEVEL% neq 0 (
	goto error
)
call "%~dp0bin\fix-nginx-apache.bat"
if %ERRORLEVEL% neq 0 (
	goto error
)
echo.
echo Instalacion completa
exit /b
:error
echo Se cancela la instalacion
exit /b %ERRORLEVEL%