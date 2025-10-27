@echo off
setlocal
call "%~dp0bin\utils.bat"
call "%~dp0config.bat"
echo Iniciando Apache %ver_apache%...
set "n=%~dp0app\apache-%ver_apache%\bin\httpd.exe"
"%n%" -d "%~dp0apache_conf" -k start
if %ERRORLEVEL% neq 0 (
	hidec.exe "%n%" -d "%~dp0apache_conf"
)
echo Iniciando NGINX %ver_nginx%...
set "n=%~dp0app\nginx\%ver_nginx%\nginx.exe"
"%n%" -p "%~dp0nginx_conf" -s reopen
if %ERRORLEVEL% neq 0 (
	hidec.exe "%n%" -p "%~dp0nginx_conf"
)
