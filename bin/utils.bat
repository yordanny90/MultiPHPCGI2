@echo off
set "add=%~dp0;%~dp0openssl;%~dp0curl;%~dp07za;"
set "p=%PATH%"
call set result=%%p:*%add%=%%
if "%result%"=="%p%" (
	set "PATH=%add%%p%"
)