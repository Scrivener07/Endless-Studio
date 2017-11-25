@ECHO off
ECHO Convert from XSD to C Sharp
SET XSD=C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\xsd.exe
ECHO XSD: %XSD%
SET DIRECTORY=E:\Lab\Amplitude\Projects\Endless-Space-2\Public\Schemas
ECHO DIRECTORY: %DIRECTORY%
SET OUTPUT=%CD%\XSD-OUT
ECHO OUTPUT: %OUTPUT%
ECHO ============================================================
MKDIR "%OUTPUT%"
PUSHD "%DIRECTORY%"
FOR /r %%i in (*.xsd) DO "%XSD%" "%%i" /c /edb /eld /o:"%OUTPUT%"
POPD
ECHO Done
