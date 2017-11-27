@ECHO OFF
CLS
SET XSD=C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\xsd.exe
SET DIRECTORY=%CD%
SET SCHEMAS=%DIRECTORY%\ES2\Public\Schemas
SET  SOURCE=%DIRECTORY%\Source\ES2.XSD
SET     LOG=%DIRECTORY%\ES2.XSD.log
IF EXIST %LOG% DEL /F %LOG%

ECHO Converting the XML schema definitions from Endless Space 2 into C# source code.
ECHO XSD:%XSD% && ECHO SCHEMAS:%SCHEMAS% && ECHO SOURCE:%SOURCE% && ECHO LOG:%LOG%
ECHO ============================================================
ECHO Please wait until XSD processing is done. Errors may be reported before processing has completed.
ECHO.
MKDIR "%SOURCE%" >> "%LOG%"
PUSHD "%SCHEMAS%"
FOR /R "%SCHEMAS%" %%F IN (*.xsd) DO "%XSD%" %%F /c /edb /l:CS /n:ES2.XSD.%%~nF_SCHEMA /nologo /o:"%SOURCE%" >> "%LOG%"
POPD
ECHO.
ECHO XSD processing is done.
