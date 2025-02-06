set WORKSPACE=..
set LUBAN_DLL=%WORKSPACE%\Tools\Luban\Luban.dll
set CONF_ROOT=.

dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-simple-json ^
    -d json ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=..\..\Assets\Scripts\GameCfgData ^
    -x outputDataDir=..\..\Assets\StreamingAssets\GameCfgData

@REM 复制生成的文件到指定目录
@REM xcopy .\out_server_jsons\* ..\..\immortal_publish\bin\res\jsons\ /E /Y

pause