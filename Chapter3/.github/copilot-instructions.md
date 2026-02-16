# Copilot Instructions - Pro C# 10 Chapter 3

## Project Overview
Educational .NET 8/10 console applications demonstrating core C# language features from "Pro C# 10" textbook. Five independent projects in a single solution, each focusing on a specific topic.

## Architecture
- **Solution**: `Chapter3_AllProjects.sln` - Visual Studio solution file managing five separate projects
- **Project Structure**: Each project is standalone with own `.csproj`, `Program.cs`, and output directory
- **Entry Points**: All projects use top-level statements in `Program.cs` (C# 9+ feature) with implicit global usings enabled
- **Framework**: Mixed targeting - Most use `net8.0`, DateTimeSpan targets `net10.0`

## Project Purposes

| Project | Purpose | Key Topics |
|---------|---------|-----------|
| **SimpleCSharpApp** | Introduction to console basics | Command-line args, `Console.WriteLine()`, `Console.ReadKey()` |
| **BasicConsoleIO** | User input/output handling | `Console.Read()`, `Console.ReadLine()`, `int.Parse()`, console colors |
| **BasicDataTypes** | Type declarations and defaults | `int`, `string`, `bool`, `System.Numerics`, `default` keyword |
| **EnvClass** | System environment inspection | `Environment` static class methods (drives, OS, version, processor count) |
| **DateTimeSpan** | Date/time operations | `DateTime`, `TimeSpan`, `DateOnly`, `TimeOnly` with factory methods and calculations |

## Build & Run Workflow

### Building
```bash
# Build all projects
dotnet build Chapter3_AllProjects.sln

# Build specific project
dotnet build SimpleCSharpApp/SimpleCSharpApp.csproj

# Release build
dotnet build -c Release
```

### Running
```bash
# Run project directly
dotnet run --project SimpleCSharpApp/SimpleCSharpApp.csproj

# Run with arguments
dotnet run --project SimpleCSharpApp/SimpleCSharpApp.csproj -- arg1 arg2

# Run compiled executable
./SimpleCSharpApp/bin/Debug/net8.0/SimpleCSharpApp
```

## Key Conventions

### Top-Level Statements Pattern
All projects use C# 9+ top-level statements (no explicit Program class/Main method):
```csharp
// Program.cs structure: Start directly with method calls/code
MethodName();
Console.ReadKey(); // Prevents immediate exit

// Supporting methods defined as static void below entry code
static void MethodName() { ... }
```

### Implicit Global Usings
Enabled in all projects via `.csproj`. No explicit `using` statements needed for:
- `System`
- `System.Collections.Generic`
- `System.Text.RegularExpressions`

### Console Interaction Pattern
Programs pause for user input before closing:
- Use `Console.ReadKey()` or `Console.ReadLine()` at program end
- Prevents premature console window closure in Visual Studio

### String Interpolation
Projects consistently use C# 6+ string interpolation:
```csharp
// Preferred
Console.WriteLine($"Value: {variableName}");

// Avoid
Console.WriteLine("Value: " + variableName);
```

## Development Environment Setup

### Prerequisites
- .NET 8 SDK (for most projects)
- .NET 10 SDK (for DateTimeSpan project)
- Visual Studio 2022+ or VS Code with C# extension

### Common Tasks

**Open solution in Visual Studio**
```bash
start Chapter3_AllProjects.sln  # Windows
open Chapter3_AllProjects.sln   # macOS
```

**Debug a specific project** - Set as startup project in Visual Studio Solution properties

**Add new project** - Create new console app project with:
```bash
dotnet new console -o NewProject
# Add to solution:
dotnet sln Chapter3_AllProjects.sln add NewProject/NewProject.csproj
```

## Important Cross-Project Patterns

- **No shared code dependencies** between projects (each is independent educational example)
- **No NuGet dependencies** beyond framework libraries
- **Output structure**: `/bin/Debug/net{version}/` contains executables
- **Project configurations**: Debug and Release builds for Any CPU, x64, x86 platforms

## File References
- Solution config: [Chapter3_AllProjects.sln](../Chapter3_AllProjects.sln)
- Per-project templates: [SimpleCSharpApp/SimpleCSharpApp.csproj](../SimpleCSharpApp/SimpleCSharpApp.csproj) (apply pattern to others)
