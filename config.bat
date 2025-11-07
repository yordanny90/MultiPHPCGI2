call "%~dp0config_default.bat"
if exist "%~dp0config_custom.bat" (
	call "%~dp0config_custom.bat"
)
