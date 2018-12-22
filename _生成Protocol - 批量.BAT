@echo off

set Path=ProtoGen\protogen.exe

for /f "delims=" %%i in ('dir /b org "org/*.proto"') do %Path% -i:org/%%i -o:cs/%%~ni.cs

pause
