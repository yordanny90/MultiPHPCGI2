@echo off
setlocal
set "php_exe=%1"
set "php_ini=%2"
if not exist "%php_exe%" (
	echo No se encontro "%php_exe%".
	exit /b 1
)

rem Habilita la carpeta de extensiones ("ext"), el fix del pathinfo (cgi) y habilita el uso de opcache (no la extension)
powershell -Command "(Get-Content '%php_ini%') -replace '^;\s*(opcache\.enable\s*=|cgi.fix_pathinfo\s*=|extension_dir\s*=\s*\"ext\")', '$1' | Set-Content '%php_ini%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo modificar el php.ini.
	exit /b %ERRORLEVEL%
)
call "%~dp0phptest.bat" %php_exe% %php_ini%
if %ERRORLEVEL% neq 0 (
	exit /b %ERRORLEVEL%
)
rem Activa extensiones requeridas
powershell -Command "(Get-Content '%php_ini%') -replace '^;((extension|zend_extension)=(php_)?(curl|mysqli|sodium|ffi|intl|ldap|ftp|gd|gd2|gettext|fileinfo|gmp|imap|mbstring|exif|openssl|odbc|pgsql|pdo_mysql|pdo_odbc|pdo_pgsql|pdo_sqlite|sqlite3|soap|sockets|zip|tidy|xsl)(.dll)?)\b', '$1' | Set-Content '%php_ini%'"
if %ERRORLEVEL% neq 0 (
	echo Error: No se habilitaron las extensiones requeridas.
	exit /b %ERRORLEVEL%
)
call "%~dp0phptest.bat" %php_exe% %php_ini%
if %ERRORLEVEL% neq 0 (
	exit /b %ERRORLEVEL%
)
exit /b 0