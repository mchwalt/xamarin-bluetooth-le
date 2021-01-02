powershell -executionpolicy bypass -file build.ps1
IF ERRORLEVEL 1 goto error

goto end

:error
@echo %ERRORLEVEL%
@echo.
@echo. Build failed.
@echo.

:end