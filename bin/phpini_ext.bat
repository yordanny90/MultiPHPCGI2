@echo off
setlocal
set "php_ini=%1"
set "op=%2"
set "ext=%3"
set "php_exe=%4"
if not exist "%php_ini%" (
	echo El archivo "%php_ini%" no existe.
	exit /b -1
)
if "%op%"=="a" (
	powershell -Command "(Get-Content '%php_ini%') -replace '^;((extension|zend_extension)=(php_)?(%ext%)(.dll)?)\b', '$1' | Set-Content '%php_ini%'"
	if %ERRORLEVEL% neq 0 (
		echo Warning: No se pudo habilitar la extension %ext%.
		exit /b -2
	)
	goto test
)
if "%op%"=="i" (
	powershell -Command "(Get-Content '%php_ini%') -replace '^((extension|zend_extension)\s*=\s*(php_)?(%ext%)(.dll)?)\b', ';$1' | Set-Content '%php_ini%'"
	if %ERRORLEVEL% neq 0 (
		echo Warning: No se pudo deshabilitar la extension %ext%.
		exit /b -2
	)
	goto test
)
echo Operación invalid. Solo se admiten: "a" (activar), "i" (inactivar)
exit /b -1
:test
if "%php_exe%" == "" (
	exit /b -1
)
call "%~dp0phptest.bat" %php_exe% %php_ini%
exit /b %ERRORLEVEL%