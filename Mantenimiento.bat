@echo off
REM OTORGA LOS PERMISOS NECESARIOS
TAKEOWN /F %WINDIR%/Temp /R
ATTRIB %WINDIR%/Temp -S -H
DEL /Q /S %WINDIR%/Temp

REM OTORGA LOS PERMISOS NECESARIOS 2
TAKEOWN /F %TMP% /R
ATTRIB %TMP% -S -H
DEL /Q /S %TMP%

REM OTORGA LOS PERMISOS NECESARIOS 3
TAKEOWN /F %TEMP% /R
ATTRIB %TEMP% -S -H
DEL /Q /S %TEMP%

pause>NUL

exit