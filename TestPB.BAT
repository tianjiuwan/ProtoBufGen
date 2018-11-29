echo on

set Path=ProtoGen\protogen.exe
set dirPath=D:
 
%Path%  -i:PlayerSnapShootMsg.proto    -o:%dirPath%\Server\DemoServer\AppMain\ProtoBufs\PlayerSnapShootMsg.cs

pause