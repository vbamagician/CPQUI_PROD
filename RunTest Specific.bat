@echo off

rem Setting up the environment variable 
set MyFirstName=Kamalam

rem The path to the .NET Core project directory
set projectDir=C:\Users\kamal.bharakhda\Downloads\Experiments\SWO_TEST\PlayWright\CPQUI

rem The name of the .NET Core project file
set projectFile=CPQUI.csproj

rem The command to run dotnet test
dotnet test %projectDir%\%projectFile% --filter "VerifyUIHealthWhileConfiguringAzureSimpleService"

rem The command to run dotnet test
livingdoc test-assembly %projectDir%\bin\Debug\net6.0\CPQUI.dll -t %projectDir%\bin\Debug\net6.0\TestExecution.json

rem Open the Result of the test
rem %projectDir%\LivingDoc.html

set /p id=Enter ID: 
echo %id%
