@echo off
setlocal
call "%~dp0bin\utils.bat"
call "%~dp0config.bat"
echo Deteniendo NGINX...
set "n=%~dp0app\nginx\%ver_nginx%\nginx.exe"
"%n%" -p "%~dp0nginx_conf" -s quit
if %ERRORLEVEL% neq 0 (
	echo Deteniendo NGINX...
	call killproc.bat nginx %~dp0
)
echo Deteniendo Apache...
call killproc.bat httpd %~dp0
echo Deteniendo PHP...
call killproc.bat php %~dp0
echo Deteniendo PHP-CGI...
call killproc.bat php-cgi %~dp0
