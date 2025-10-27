@echo off
setlocal
call "%~dp0utils.bat"
set "ver=%1"
set "name=apache-%ver%"
set "install_dir=%~dp0..\app\%name%"
set "app_exe=%install_dir%\bin\httpd.exe"
set "_tmp=%~dp0..\tmp"
if "%ver%"=="" (
	echo Debe indicar una version de Apache para instalar.
	exit /b 1
)

echo Instalacion de Apache %ver%
if exist "%app_exe%" (
	echo La instalacion ya existe.
	exit /b
)

set "url=https://www.apachelounge.com/download/VS17/binaries/"
set "zipfile=httpd-%ver%-Win64-VS17.zip"
for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
set "zipfile="
:found
if "%zipfile%"=="" (
	echo Error: Version de Apache no encontrada.
	exit /b 2
)
if not exist "%_tmp%" (
	@mkdir "%_tmp%"
)

call download-fcgid.bat
if %ERRORLEVEL% neq 0 (
	echo Error: No se pudo descargar mod_fcgid.
	exit /b %ERRORLEVEL%
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

if not exist "%_tmp%\%name%\Apache24\bin\httpd.exe" (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: Archivo de instalacion invalido.
	exit /b 1
)

set "mod_fcgid=mod_fcgid.so"
echo Copiando "%mod_fcgid%"
copy /Y "%_tmp%\%mod_fcgid%" "%_tmp%\%name%\Apache24\modules\%mod_fcgid%"
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo copiar "%mod_fcgid%".
	exit /b %ERRORLEVEL%
)

if not exist "%install_dir%" (
	@mkdir "%install_dir%"
)

echo Copiando a "%install_dir%"
xcopy "%_tmp%\%name%\Apache24\" "%install_dir%" /e /h /i /y /j
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo copiar la carpeta de Apache.
	exit /b %ERRORLEVEL%
)

echo Eliminando archivos temporales...
rmdir /s /q "%_tmp%\%name%"

if not exist "%app_exe%" (
	echo Error: No se pudo completar la instalacion.
	exit /b 1
)
