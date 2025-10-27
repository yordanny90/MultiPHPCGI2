@echo off
setlocal
call "%~dp0utils.bat"
set name=localhost
set dir=%~dp0..\
set certdir=%dir%app\ssl\
set _tmp=%dir%tmp\openssl\
if exist "%certdir%%name%.crt" (
	echo Ya existe el certificado "%certdir%%name%.crt"
	if "%1" == "n" (
		goto new
	)
	if "%1" == "r" (
		goto register
	)
	exit /b
)

:new
echo Generando nuevo certificado...
if not exist "%_tmp%" (
	mkdir "%_tmp%"
)
copy "%dir%ssl_conf\openssl.conf" "%_tmp%openssl.conf"
call "%~dp0cert_iplist.bat" "%_tmp%openssl.conf"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe genpkey -algorithm RSA -out "%_tmp%\private.key"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe req -new -key "%_tmp%\private.key" -out "%_tmp%\request.csr" -config "%_tmp%openssl.conf"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe x509 -req -days 3650 -in "%_tmp%\request.csr" -signkey "%_tmp%\private.key" -out "%_tmp%\certificate.crt" -extensions v3_ca -extfile "%_tmp%openssl.conf"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
echo. > "%_tmp%certificate.pem"
echo # Certificado local >> "%_tmp%certificate.pem"
echo. >> "%_tmp%certificate.pem"
type "%_tmp%\certificate.crt" >> "%_tmp%certificate.pem"
echo. >> "%_tmp%certificate.pem"
echo # Llave local >> "%_tmp%certificate.pem"
echo. >> "%_tmp%certificate.pem"
type "%_tmp%\private.key" >> "%_tmp%certificate.pem"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)

@echo Verificando certificados
openssl.exe rsa -in "%_tmp%\private.key" -check
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe req -in "%_tmp%\request.csr" -noout -text -config "%_tmp%openssl.conf"
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe x509 -in "%_tmp%\certificate.crt" -noout -text
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
openssl.exe x509 -in "%_tmp%\certificate.pem" -noout -text
if %ERRORLEVEL% neq 0 (
	echo Error de openssl
	exit /b %ERRORLEVEL%
)
@mkdir "%certdir%"
copy /Y "%_tmp%private.key" "%certdir%%name%.key"
copy /Y "%_tmp%certificate.crt" "%certdir%%name%.crt"
copy /Y "%_tmp%certificate.pem" "%certdir%%name%.pem"
copy /Y "%_tmp%openssl.conf" "%certdir%%name%.conf"
del "%_tmp%private.key"
del "%_tmp%certificate.crt"
del "%_tmp%certificate.pem"
del "%_tmp%openssl.conf"
del "%_tmp%request.csr"
:register
echo Registrando certificado...
net session >nul 2>&1
if %ERRORLEVEL% neq 0 (
	powershell -Command "Start-Process certutil -ArgumentList '-addstore -f \"Root\" \"%certdir%%name%.crt\"' -Verb RunAs"
) else (
	certutil -addstore -f "Root" "%certdir%%name%.crt"
)
if %ERRORLEVEL% neq 0 (
	start "" "%certdir%%name%.crt"
	exit /b %ERRORLEVEL%
)
