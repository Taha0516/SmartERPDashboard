@echo off
title Smart ERP Dashboard - Local Web Server
color 0b

:: Ensure the script runs in its current folder
cd /d "%~dp0"

echo ====================================================================
echo                 Smart ERP Dashboard (Release Build)                 
echo ====================================================================
echo.
echo Checking for available local web servers on your system...
echo.

:: 1. Check for .NET SDK (Most likely since this is a Blazor dev environment)
dotnet --version >nul 2>&1
if %errorlevel% equ 0 (
    echo [OK] .NET SDK detected.
    echo Installing dotnet-serve tool if not present...
    dotnet tool install --global dotnet-serve >nul 2>&1
    
    echo Starting local HTTP server on port 8080...
    echo Press CTRL+C to stop the server at any time.
    echo.
    
    start http://localhost:8080
    
    :: Try standard command, fallback to explicit path if PATH isn't updated yet
    dotnet serve -d wwwroot -p 8080 || "%USERPROFILE%\.dotnet\tools\dotnet-serve.exe" -d wwwroot -p 8080
    
    echo.
    echo Server process ended.
    pause
    exit /b
)

:: 2. Check for npx (Node.js)
call npx --version >nul 2>&1
if %errorlevel% equ 0 (
    echo [OK] Node.js (npx) detected. 
    echo Starting local HTTP server on port 8080...
    echo Press CTRL+C to stop the server at any time.
    echo.
    
    start http://localhost:8080
    call npx -y http-server wwwroot -p 8080 --cors -c-1
    
    echo.
    echo Server process ended.
    pause
    exit /b
)

:: 3. Check for Python (Using a command that avoids the Windows Store alias trap)
python -c "print('OK')" >nul 2>&1
if %errorlevel% equ 0 (
    echo [OK] Python detected. 
    echo Starting local HTTP server on port 8080...
    echo Press CTRL+C to stop the server at any time.
    echo.
    
    start http://localhost:8080
    python -m http.server 8080 -d wwwroot
    
    echo.
    echo Server process ended.
    pause
    exit /b
)

:: 4. Check for Python3
python3 -c "print('OK')" >nul 2>&1
if %errorlevel% equ 0 (
    echo [OK] Python3 detected. 
    echo Starting local HTTP server on port 8080...
    echo Press CTRL+C to stop the server at any time.
    echo.
    
    start http://localhost:8080
    python3 -m http.server 8080 -d wwwroot
    
    echo.
    echo Server process ended.
    pause
    exit /b
)

echo [ERROR] No suitable web server engine found!
echo.
echo To run this WebAssembly application, you need to host the "wwwroot" folder 
echo on a local web server because modern browsers block file:// execution.
echo.
echo Solutions:
echo 1. Install Node.js from nodejs.org and run this script again.
echo 2. Install Python from python.org and run this script again.
echo 3. If you use VS Code, open the "wwwroot" folder and use the "Live Server" extension.
echo.
pause
