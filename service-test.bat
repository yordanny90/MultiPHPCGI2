@echo off
setlocal
call "%~dp0config.bat"
set "err="
echo Apache %ver_apache%
"%~dp0app\apache-%ver_apache%\bin\httpd.exe" -d "%~dp0apache_conf" -t
if %ERRORLEVEL% neq 0 (
	set "err=apache"
)
echo NGINX %ver_nginx%
"%~dp0app\nginx\%ver_nginx%\nginx.exe" -p "%~dp0nginx_conf" -t
if %ERRORLEVEL% neq 0 (
	set "err=nginx"
)
if "%err%" == "" (
	echo Prueba existosa
) else (
	echo Prueba fallida de %err%
)
if "%1" neq "" (
	pause
)
if "%err%" == "" (
	exit /b
)
exit /b 1