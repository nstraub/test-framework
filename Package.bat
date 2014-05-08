@echo off
echo Cleaning nuget publish folder.

if exist nuget rd nuget /S /Q
md nuget

tools\NuGet\NuGet.exe pack src\TestFramework.NUnit.Ninject.Moq\TestFramework.NUnit.Ninject.Moq.csproj -build -Properties Configuration=Release -OutputDirectory nuget
tools\NuGet\NuGet.exe pack src\TestFramework.NUnit.Ninject.NSubstitute\TestFramework.NUnit.Ninject.NSubstitute.csproj -build -Properties Configuration=Release -OutputDirectory nuget