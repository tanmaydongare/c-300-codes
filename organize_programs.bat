@echo off
echo Organizing C# programs by difficulty levels...

echo Copying Level 1 programs (1-50)...
for /L %%i in (1,1,50) do (
    if exist "CSharpPrograms\Program%%03i.cs" (
        copy "CSharpPrograms\Program%%03i.cs" "Levels\Level1_Basics\" >nul
        echo   Program%%03i.cs -> Level1_Basics
    )
)

echo Copying Level 2 programs (51-100)...
for /L %%i in (51,1,100) do (
    if exist "CSharpPrograms\Program%%03i.cs" (
        copy "CSharpPrograms\Program%%03i.cs" "Levels\Level2_Advanced\" >nul
        echo   Program%%03i.cs -> Level2_Advanced
    )
)

echo Copying Level 3 programs (101-150)...
for /L %%i in (101,1,150) do (
    if exist "CSharpPrograms\Program%%03i.cs" (
        copy "CSharpPrograms\Program%%03i.cs" "Levels\Level3_OOP\" >nul
        echo   Program%%03i.cs -> Level3_OOP
    )
)

echo Copying Level 4 programs (151-200)...
for /L %%i in (151,1,200) do (
    if exist "CSharpPrograms\Program%%03i.cs" (
        copy "CSharpPrograms\Program%%03i.cs" "Levels\Level4_Enterprise\" >nul
        echo   Program%%03i.cs -> Level4_Enterprise
    )
)

echo.
echo Organization complete!
echo.
echo Summary:
echo   Level 1 (Basics):        50 programs
echo   Level 2 (Advanced):      50 programs  
echo   Level 3 (OOP):           50 programs
echo   Level 4 (Enterprise):    50 programs
echo   Total:                   200 programs
echo.
pause
