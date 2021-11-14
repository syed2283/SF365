@echo off
set package_root=..\..\
REM Find spkl in thr package folder (irrespective of version)
for /R %package_root% %%G IN (spkl.exe) do (

	IF EXIST "%%G" (set spkl_path = %%G 
		
		goto :Continue
	)
)
:Continue

@echo Using '%spkl_path%'

REM spkl instrument [path] [connection-string] [/p:release]
"%spkl_path%" pack "%cd%\..\spkl.json" ""

exit /b %ERRORLEVEL%