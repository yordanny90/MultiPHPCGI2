@echo off
setlocal
call "%~dp0bin\utils.bat"
call "%~dp0config.bat"
echo Reiniciando Apache %ver_apache%...
set "n=%~dp0app\apache-%ver_apache%\bin\httpd.exe"
call killproc.bat httpd %~dp0
hidec.exe "%n%" -d "%~dp0apache_conf"
echo Reiniciando NGINX %ver_nginx%...
set "n=%~dp0app\nginx\%ver_nginx%\nginx.exe"
"%n%" -p "%~dp0nginx_conf" -s reload
if %ERRORLEVEL% neq 0 (
	echo Deteniendo NGINX...
	call killproc.bat nginx %~dp0
	hidec.exe "%n%" -p "%~dp0nginx_conf"
)
