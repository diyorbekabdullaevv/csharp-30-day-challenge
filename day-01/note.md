# Day 1 — C# Introduction and Syntax

**Date:** October 5, 2026
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Introduction

I learned what C# is, who created it, and what it can be used for.

**C#:** A programming language developed by Microsoft that runs on the .NET platform.

**C# versions:** C# was first released in 2002 and the latest version is C# 14, released in November 2025.

**C# uses:** C# can be used to build mobile applications, desktop applications, web applications, web services, websites, games, VR applications, and database applications.

**Similar languages:** C# is similar to languages such as C++ and Java, so learning C# can make it easier to understand these languages.

### Why Use C#?

I learned some reasons why C# is useful for programming.

**Easy to understand:** C# has a clear and structured syntax.

**Simple to write:** C# provides syntax and features that make writing programs easier.

**Similar to other languages:** Its similarities to C++ and Java can make it easier to learn other programming languages.

### IDE

I learned what an IDE is and why it is used.

**IDE (Integrated Development Environment):** A software application used to write, edit, and compile code.

### C# Syntax

I learned the basic structure of a C# program and what each part of the code means.

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

**`using System;`**: Allows the program to use classes from the `System` namespace.

**Blank lines:** C# ignores blank lines. They can be used to organize code and make it more readable.

**`namespace HelloWorld`**: Organizes related code and helps avoid naming conflicts.

**`{ }`**: Curly braces mark the beginning and end of a block of code.

**`class Program`**: Defines a class named `Program`. A class is a container that can hold data and methods.

**`static`**: Means the method belongs to the `Program` class itself, so it can be called without creating a `Program` object.

**`void`**: Means the method does not return a value.

**`Main`**: The special method where the program starts executing.

**`string[] args`**: An array of text values that can receive arguments passed to the program from outside.

**`Console.WriteLine()`**: Writes text to the console and then moves to a new line.

**`.`**: Used to access something that belongs to an object or class, such as `WriteLine` from `Console`.

**`WriteLine`**: A method that prints text to the console and moves to the next line.

**`"Hello World!"`**: The text that the program prints. It is a string.

**`;`**: Marks the end of a statement.

## Exercises

1. **Hello World**
   Wrote a basic C# program that prints `Hello World!` to the console.

2. **Understanding C# Syntax**
   Practiced identifying and understanding the purpose of `using`, `namespace`, `class`, `static`, `void`, `Main`, and `Console.WriteLine()`.

3. **Code Structure**
   Practiced understanding how curly braces, statements, strings, methods, and classes are organized in a C# program.

## Next

- Learn C# Output
- Learn C# Comments
- Learn C# Variables
