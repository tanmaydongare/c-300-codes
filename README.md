# C# Programming Practice Repository

This repository contains a comprehensive collection of 200 C# programming exercises organized across 4 levels of difficulty, based on the provided PDF syllabus.

## 📁 Project Structure

```
c-300-codes/
├── README.md                    # This file
├── generate_csharp_programs.py  # Original generator script
├── CSharpPrograms/              # All 200 programs (flat structure)
│   ├── Program001.cs - Program200.cs
│   └── ...
├── Levels/                      # NEW: Organized by difficulty levels
│   ├── Level1_Basics/           # Programs 1-50: C# Basics & Core Programming
│   ├── Level2_Advanced/         # Programs 51-100: Arrays, Strings & Methods
│   ├── Level3_OOP/              # Programs 101-150: OOPs & Advanced C#
│   └── Level4_Enterprise/       # Programs 151-200: Enterprise, .NET & Real-World
├── Documentation/               # NEW: Detailed documentation
│   ├── Program_Descriptions.md  # Detailed descriptions for each program
│   ├── Level_Guides/            # Study guides for each level
│   └── Best_Practices.md        # C# coding best practices
└── Tools/                       # NEW: Additional utilities
    ├── Program_Launcher.cs      # Interactive program runner
    ├── Test_Framework.cs        # Simple testing framework
    └── Code_Analyzer.cs         # Code quality analyzer
```

## 🎯 Program Levels

### Level 1: C# Basics & Core Programming (1-50)
- **Focus**: Syntax, logic building, console applications
- **Topics**: Variables, operators, control flow, basic I/O, data types
- **Prerequisites**: None
- **Example Programs**: Hello World, arithmetic operations, conditional statements, loops

### Level 2: Arrays, Strings & Methods (51-100)
- **Focus**: Problem solving, reusability, data structures
- **Topics**: Arrays, strings, methods, recursion, collections
- **Prerequisites**: Level 1 completion
- **Example Programs**: Array operations, string manipulation, method overloading

### Level 3: OOPs & Advanced C# (101-150)
- **Focus**: Industry-critical concepts, object-oriented programming
- **Topics**: Classes, inheritance, polymorphism, exceptions, LINQ, async/await
- **Prerequisites**: Level 2 completion
- **Example Programs**: Class design, inheritance hierarchies, exception handling

### Level 4: Enterprise, .NET & Real-World Programs (151-200)
- **Focus**: Job-ready skills, enterprise development
- **Topics**: Web APIs, databases, authentication, cloud deployment, microservices
- **Prerequisites**: Level 3 completion
- **Example Programs**: REST APIs, database CRUD, authentication systems

## 🚀 Quick Start

### Running Individual Programs
Each program is a standalone console application:

```bash
# Navigate to the desired level
cd Levels/Level1_Basics/

# Run a specific program
dotnet run --project Program001.csproj

# Or compile and run directly
csc Program001.cs
Program001.exe
```

### Using the Interactive Launcher
```bash
cd Tools/
dotnet run --project Program_Launcher.csproj
```

### Generating Programs
To regenerate all programs from the original generator:

```bash
python generate_csharp_programs.py
```

## 📚 Documentation

### Program Descriptions
Each program includes:
- Clear problem statement
- Input/output examples
- Algorithm explanation
- Key concepts covered
- Time/space complexity analysis

### Level Guides
Study guides for each level include:
- Learning objectives
- Key concepts summary
- Practice exercises
- Common pitfalls and solutions
- Next steps recommendations

### Best Practices
C# coding standards and best practices:
- Naming conventions
- Code organization
- Performance considerations
- Security guidelines
- Testing strategies

## 🛠️ Tools and Utilities

### Program Launcher
Interactive console application for:
- Browsing programs by level
- Running programs with sample inputs
- Viewing program descriptions
- Tracking progress

### Test Framework
Simple testing framework for:
- Unit testing individual programs
- Automated test execution
- Test result reporting
- Performance benchmarking

### Code Analyzer
Static analysis tool for:
- Code quality assessment
- Best practice compliance
- Performance optimization suggestions
- Security vulnerability detection

## 🎓 Learning Path

### For Beginners
1. Start with Level 1 programs in order
2. Complete all programs in a level before moving to the next
3. Use the documentation and level guides
4. Practice regularly and track progress

### For Experienced Developers
1. Review Level 1-2 for syntax refreshers
2. Focus on Level 3 for OOP concepts
3. Master Level 4 for enterprise skills
4. Use the tools for code quality and testing

### For Job Preparation
1. Complete all levels systematically
2. Focus on Level 4 enterprise programs
3. Use the test framework to validate solutions
4. Practice explaining your code and design decisions

## 🤝 Contributing

We welcome contributions to improve this repository:

1. **Bug Reports**: Report issues with specific programs
2. **Enhancements**: Suggest improvements to existing programs
3. **Documentation**: Help improve documentation and guides
4. **New Programs**: Propose additional programs for advanced topics

## 📝 License

This repository is licensed under the MIT License - see the LICENSE file for details.

## 🙏 Acknowledgments

- Dr. Kiran Khandarkar for the original program syllabus
- The C# and .NET community for excellent documentation and tools
- Contributors who help maintain and improve this repository

---

**Happy Coding! 🚀**