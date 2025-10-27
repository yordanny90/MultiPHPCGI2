@echo off
setlocal enabledelayedexpansion
set "i=1"
set "sslconf=%1"
for /f "tokens=2 delims=:" %%A in ('ipconfig ^| findstr /R "IPv4 Address[^0-9: ]*:([.0-9]+)"') do (
	set /a i+=1
	echo IP.!i!=%%A>> %sslconf%
)