# Smart ERP Dashboard - Distribution Package

This package contains the fully compiled "Release" version of the Smart ERP Dashboard.
Since this is a Blazor WebAssembly (Frontend-only) application, it runs entirely in the browser.

## How to Run Locally

WebAssembly applications cannot be opened directly by double-clicking `index.html` (due to browser security restrictions on the `file://` protocol). They must be served over an HTTP server.

**Easiest Method:**
Simply double-click the **`Start-Dashboard.bat`** file.
This intelligent script will automatically search your computer for common web server tools (Python, Node.js, or .NET), launch the server, and automatically open your web browser to `http://localhost:8080`.

**Alternative Method (VS Code):**
1. Open the `wwwroot` folder in Visual Studio Code.
2. Install the **"Live Server"** extension.
3. Right-click `index.html` and select **"Open with Live Server"**.

## Files to Share

If you want to share this project with someone else, you only need to zip and share this entire folder (the folder containing this README).

The required files/folders for distribution are:
- `wwwroot/` (Contains all the compiled app files, DLLs, CSS, and JS)
- `Start-Dashboard.bat` (The easy-start script)
- `README_Distribution.txt` (This instruction file)

*(Note: The `web.config` and `.json` files in the root are optional and only needed if deploying to Microsoft IIS).*

Enjoy the Dashboard!
