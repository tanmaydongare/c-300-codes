# C# Programs 1 to 200

This package contains 200 standalone C# programs organized by level.

## Requirements
- .NET SDK 8.0+ (or newer)
- Windows / Linux / macOS terminal

## Folder Structure
- `Level1_Basics` (Program001 - Program050)
- `Level2_Arrays_Strings` (Program051 - Program100)
- `Level3_OOP_Advanced` (Program101 - Program150)
- `Level4_Enterprise_DotNet` (Program151 - Program200)

## How to Run a Program
1. Open terminal in this project root.
2. Pick a file, for example:
   - `Level1_Basics/Program001_HelloWorld.cs`
3. Run using `dotnet-script` (if installed):
   ```bash
   dotnet script Level1_Basics/Program001_HelloWorld.cs
   ```

Alternative with C# compiler (`csc`):
```bash
csc Level1_Basics/Program001_HelloWorld.cs
Program001_HelloWorld.exe
```

> Each file is self-contained and includes `using System;`, a `Program` class, and `Main()`.
