@echo off
setlocal
call "%~dp0utils.bat"
set "ver=%1"
set "name=%ver%"
set "install_dir=%~dp0..\app\php\%ver%"
set "app_exe=%install_dir%\php.exe"
set "_tmp=%~dp0..\tmp"
if "%ver%"=="" (
	echo Debe indicar una version de PHP para instalar.
	exit /b 1
)

echo Instalacion de PHP version %ver%
if exist "%app_exe%" (
	if "%2"=="rebuild" (
		call "%~dp0rebuild-php.bat" %ver%
		exit /b %ERRORLEVEL%
	)
	if not exist "%install_dir%\php.ini" (
		call "%~dp0rebuild-php.bat" %ver%
		exit /b %ERRORLEVEL%
	)
	echo La instalacion ya existe.
	goto fix
)

set "url=https://windows.php.net/downloads/releases/archives/"
set "verbase=%ver:~0,2%"
if "%verbase%"=="5." (
	set "zipfile=php-%ver%-Win32-vc11-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile="
) else if "%verbase%"=="7." (
	set "zipfile=php-%ver%-Win32-vc14-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile=php-%ver%-Win32-vc15-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile="
) else if "%verbase%"=="8." (
	set "zipfile=php-%ver%-Win32-vs16-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile=php-%ver%-Win32-vs17-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile=php-%ver%-Win32-vs18-x64.zip"
	for /f %%a in ('curl.exe -I -s -w "%%{http_code}" "%%url%%%%zipfile%%"') do if "%%a"=="200" (goto found)
	set "zipfile="
) else (
	echo Error: Version de PHP invalida.
	exit /b 1
)
:found
if "%zipfile%"=="" (
	echo Error: Version de PHP no encontrada.
	exit /b 2
)
echo URL encontrada "%url%%zipfile%"
rmdir /s /q "%_tmp%\%name%\"
@mkdir "%_tmp%\%name%\"
curl.exe -s -o "%_tmp%\%name%\%zipfile%" "%url%%zipfile%"
if %ERRORLEVEL% neq 0 (
	exit /b %ERRORLEVEL%
)

if not exist "%_tmp%\%name%\%zipfile%" (
	echo Error: No se pudo descargar el archivo.
	exit /b 1
)

echo Descomprimiendo ZIP...
7za.exe x "%_tmp%\%name%\%zipfile%" "-o%_tmp%\%name%\php\"
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: No se pudo descomprimir el archivo.
	exit /b %ERRORLEVEL%
)

if not exist "%_tmp%\%name%\php\php.exe" (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: Archivo de instalacion invalido.
	exit /b 1
)

set "tmp_exe=%_tmp%\%name%\php\php.exe"
set "php_ini=%_tmp%\%name%\php\php.ini.tmp"
copy /Y "%_tmp%\%name%\php\php.ini-production" "%php_ini%"
if not exist "%php_ini%" (
	echo Error: No se pudo copiar el php.ini.
	exit /b 1
)
call "%~dp0rebuild-phpdir.bat" %tmp_exe% %php_ini%
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	echo Error: Archivo de instalacion invalido.
	exit /b 1
)

if not exist "%install_dir%" (
	@mkdir "%install_dir%"
)

echo Copiando a "%install_dir%"
xcopy "%_tmp%\%name%\php\" "%install_dir%" /e /h /i /y /j
if %ERRORLEVEL% neq 0 (
	rmdir /s /q "%_tmp%\%name%"
	rmdir /s /q "%install_dir%"
	echo Error: No se pudo copiar la carpeta de PHP.
	exit /b %ERRORLEVEL%
)

echo Eliminando archivos temporales...
rmdir /s /q "%_tmp%\%name%"

if not exist "%app_exe%" (
	rmdir /s /q "%install_dir%"
	echo Error: No se pudo completar la instalacion.
	exit /b 1
)

call "%~dp0rebuild-php.bat" %ver%
echo Instalacion existosa

:fix