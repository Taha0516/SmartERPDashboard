# Smart ERP Dashboard - Distribution Package

This package contains the fully compiled "Release" version of the Smart ERP Dashboard.
Since this is a Blazor WebAssembly (Frontend-only) application, it runs entirely in the browser.

## How to Run Locally

WebAssembly applications cannot be opened directly by double-clicking `index.html` (due to browser security restrictions on the `file://` protocol). They must be served over an HTTP server.

To make this completely frictionless, we have included a tiny, 100% portable, standalone web server inside this folder (`miniserve.exe`).

**For Windows Users:**
1. Extract the ZIP file completely (Do not run this from inside the ZIP).
2. Simply double-click the **`Start-Dashboard.bat`** file.
*(It will automatically start the portable server and open your browser).*

**For Mac / Apple Users:**
Simply double-click the **`Start-Dashboard-Mac.command`** file.
*(Note: If macOS says you don't have permission to open it, open your Terminal, type `chmod +x `, drag and drop the file into the terminal, and press Enter. Then double-click it again).*

## Files to Share

If you want to share this project with someone else, you only need to zip and share this entire folder (the folder containing this README).

The required files/folders for distribution are:
- `wwwroot/` (Contains all the compiled app files, DLLs, CSS, and JS)
- `miniserve.exe` (The tiny portable web server)
- `Start-Dashboard.bat` (For Windows users)
- `Start-Dashboard-Mac.command` (For Mac users)
- `README_Distribution.txt` (This instruction file)

Enjoy the Dashboard!
