@echo off
powershell -Command "(Get-NetIPAddress | Where-Object { $_.AddressFamily -like 'IPv4' } | Select-Object InterfaceAlias, IPAddress, AddressFamily, AddressState)"
if "%1" neq "" (pause)