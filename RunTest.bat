@echo off

rem The path to the .NET Core project directory
set projectDir=C:\Users\kamal.bharakhda\Downloads\Experiments\SWO_TEST\PlayWright\CPQUI

rem The name of the .NET Core project file
set projectFile=CPQUI.csproj

rem The command to run dotnet test
dotnet test %projectDir%\%projectFile%

rem The command to run dotnet test
livingdoc test-assembly %projectDir%\bin\Debug\net6.0\CPQUI.dll -t %projectDir%\bin\Debug\net6.0\TestExecution.json

set /p id=Enter ID: 
echo %id%

rem Open the Result of the test
rem %projectDir%\LivingDoc.html

rem Send Report via Email to Business
setlocal
set PARAM1=lock

rem Send Report via Email to Business
start excel %projectDir%\EmailingReport.xlsm
