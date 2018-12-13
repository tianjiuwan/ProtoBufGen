echo on

set Path=ProtoGen\protogen.exe
set dirPath=D:
 
%Path%  -i:org\PlayerInfoMsg.proto    -o:%dirPath%\Server\DemoServer\AppMain\ProtoBufs\PlayerInfoMsg.cs

pause