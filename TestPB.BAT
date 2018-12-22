echo on

set Path=ProtoGen\protogen.exe
set dirPath=D:
 
%Path%  -i:org\SyncPlayerPosResp.proto    -o:%dirPath%\DemoServer\AppMain\ProtoBufs\SyncPlayerPosResp.cs

pause