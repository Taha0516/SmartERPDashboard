@echo off
title Smart ERP Dashboard
color 0b

:: Ensure the script runs in its current folder
cd /d "%~dp0"

echo ====================================================================
echo                 Smart ERP Dashboard (Release Build)                 
echo ====================================================================
echo.
echo Starting standalone local web server...
echo.

:: Check if our portable server exists
if not exist "miniserve.exe" (
    echo [ERROR] miniserve.exe was not found in this folder!
    echo Please ensure you extracted all files from the ZIP before running.
    pause
    exit /b
)

echo Press CTRL+C to stop the server at any time.
echo.

:: Open browser
start http://localhost:8080

:: Run the portable web server serving the wwwroot directory on port 8080
miniserve.exe wwwroot -p 8080 --index index.html

echo.
echo Server process ended.
pause
exit /b
