@echo off

rem The path to the .NET Core project directory
set projectDir=%CD%

rem Send Report via Email to Business
setlocal
set PARAM1=unlock

rem Send Report via Email to Business
start excel %projectDir%\EmailingReport.xlsm