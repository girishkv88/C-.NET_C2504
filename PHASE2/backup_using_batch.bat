@echo off
setlocal


set "SOURCE=C:\TestFiles"
set "BACKUP=D:\Backups"


set "DAYS_TO_KEEP=7"


for /f "tokens=2 delims==" %%I in ('wmic os get localdatetime /value ^| find "="') do set "DATETIME=%%I"
set "CURRENT_DATE=%DATETIME:~0,8%"


set "BACKUP_FOLDER=%BACKUP%\%CURRENT_DATE%"
if not exist "%BACKUP_FOLDER%" (
    mkdir "%BACKUP_FOLDER%"
)


set "FILE_COUNT=0"
xcopy "%SOURCE%\*" "%BACKUP_FOLDER%\" /E /I /Y /H /S > nul
if ERRORLEVEL 1 (
    echo Backup failed during file copy!
    set "BACKUP_SUCCESS=0"
) else (
    for /f %%A in ('dir /b "%BACKUP_FOLDER%\*" ^| find /c /v ""') do set "FILE_COUNT=%%A"
    set "BACKUP_SUCCESS=1"
)




forfiles /p "%BACKUP%" /d -%DAYS_TO_KEEP% /c "cmd /c rmdir /s /q @path"


set "LOG_FILE=%BACKUP%\backup_log.txt"
(
    echo Backup Date and Time: %DATE% %TIME%
    echo Number of files copied: %FILE_COUNT%
    echo Backup folder: %BACKUP_FOLDER%
    echo.
) >> "%LOG_FILE%"

if "%BACKUP_SUCCESS%"=="1" (
    echo Backup completed successfully!
) else (
    echo Backup failed!
)

pause
endlocal
