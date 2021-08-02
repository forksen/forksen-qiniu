@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Forksen.Qiniu\bin\Release\Forksen.Qiniu.*.nupkg D:\LocalSavoryNuget\

pause