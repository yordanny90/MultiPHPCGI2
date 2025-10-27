@echo off
setlocal
call "%~dp0utils.bat"
set "_tmp=%~dp0..\tmp"
set "name=mod_fcgid"

set "url=https://www.apachelounge.com/download/VS17/modules/"
set "zipfile=mod_fcgid-2.3.10-win64-VS17.zip"
for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
set "zipfile="
:found
if "%zipfile%"=="" (
	echo Error: Version de mod_fcgid no encontrada.
	exit /b 2
)
if not exist "%_tmp%" (
	@mkdir "%_tmp%"
)

rmdir /s /q "%_tmp%\%name%\"
@mkdir "%_tmp%\%name%\"
curl.exe -s -o "%_tmp%\%name%\%zipfile%" "%url%%zipfile%"
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo descargar el archivo.
	exit /b %ERRORLEVEL%
)
if not exist "%_tmp%\%name%\%zipfile%" (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo descargar el archivo.
	exit /b 1
)

echo Descomprimiendo ZIP...
7za.exe x "%_tmp%\%name%\%zipfile%" "-o%_tmp%\%name%\"
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo descomprimir el archivo.
	exit /b %ERRORLEVEL%
)

if not exist "%_tmp%\%name%\%name%.so" (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: Archivo de instalacion invalido.
	exit /b 1
)

echo copy /Y "%_tmp%\%name%\%name%.so" "%_tmp%\mod_fcgid.so"
copy /Y "%_tmp%\%name%\%name%.so" "%_tmp%\mod_fcgid.so"
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo copiar %name%.
	exit /b %ERRORLEVEL%
)

rmdir /s /q "%_tmp%\%name%"
exit /b 0