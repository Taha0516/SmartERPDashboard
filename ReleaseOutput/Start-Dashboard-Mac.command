#!/bin/bash
cd "$(dirname "$0")"

echo "===================================================================="
echo "                 Smart ERP Dashboard (Release Build)                 "
echo "===================================================================="
echo ""
echo "Checking for available local web servers on your system..."
echo ""

# 1. Check for Python 3 (Built into macOS)
if command -v python3 &> /dev/null; then
    echo "[OK] Python 3 detected."
    echo "Starting local HTTP server on port 8080..."
    echo "Press CTRL+C to stop the server at any time."
    echo ""
    open "http://localhost:8080" 2>/dev/null || xdg-open "http://localhost:8080" 2>/dev/null
    python3 -m http.server 8080 -d wwwroot
    exit 0
fi

# 2. Check for Python 2 (Older macOS)
if command -v python &> /dev/null; then
    echo "[OK] Python detected."
    echo "Starting local HTTP server on port 8080..."
    echo "Press CTRL+C to stop the server at any time."
    echo ""
    open "http://localhost:8080" 2>/dev/null || xdg-open "http://localhost:8080" 2>/dev/null
    cd wwwroot && python -m SimpleHTTPServer 8080
    exit 0
fi

# 3. Check for PHP (Built into older macOS)
if command -v php &> /dev/null; then
    echo "[OK] PHP detected."
    echo "Starting local HTTP server on port 8080..."
    echo "Press CTRL+C to stop the server at any time."
    echo ""
    open "http://localhost:8080" 2>/dev/null || xdg-open "http://localhost:8080" 2>/dev/null
    php -S localhost:8080 -t wwwroot
    exit 0
fi

# 4. Check for npx (Node.js)
if command -v npx &> /dev/null; then
    echo "[OK] Node.js (npx) detected."
    echo "Starting local HTTP server on port 8080..."
    echo "Press CTRL+C to stop the server at any time."
    echo ""
    open "http://localhost:8080" 2>/dev/null || xdg-open "http://localhost:8080" 2>/dev/null
    npx -y http-server wwwroot -p 8080 --cors -c-1
    exit 0
fi

echo "[ERROR] No suitable web server engine found!"
echo ""
echo "To run this WebAssembly application, you need to host the 'wwwroot' folder"
echo "on a local web server because modern browsers block file:// execution."
echo ""
echo "Please install Node.js or Python."
echo ""
read -p "Press Enter to exit..."
