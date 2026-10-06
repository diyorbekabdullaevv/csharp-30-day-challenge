# Day 2 — C# Output, Comments, and Variables

**Date:** October 6, 2026
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Output

I learned how to display text, numbers, and calculations in the console using `WriteLine()` and `Write()`.

**`Console.WriteLine()`**: Prints a value to the console and moves the cursor to a new line.

**`Console.Write()`**: Prints a value but keeps the cursor on the same line.

**Mathematical calculations**: `Console.WriteLine()` can also display the result of mathematical expressions.

### C# Comments

I learned how to add comments to C# code to explain what the code does and make it easier to understand.

**`//`**: Creates a single-line comment. Everything after `//` on that line is ignored by the compiler.

**`/* */`**: Creates a multi-line comment. Everything between `/*` and `*/` is ignored by the compiler.

**Comments:** Comments are used to explain code and improve readability.

### C# Variables

I learned that variables are containers used to store data values.

**`int`**: Stores whole numbers, such as `123` or `-123`.

**`double`**: Stores decimal numbers, such as `19.99` or `-19.99`.

**`char`**: Stores a single character, such as `'A'` or `'D'`.

**`string`**: Stores text, such as `"Hello World"`.

**`bool`**: Stores one of two values: `true` or `false`.

I also learned that a variable can be declared first and assigned a value later.

**Reassigning a variable:** Assigning a new value to an existing variable replaces its previous value.

### C# Constants

I learned how to create values that cannot be changed after they are assigned.

**`const`**: Makes a variable constant, meaning its value cannot be changed.

```csharp
const int myNum = 15;
```

Trying to change `myNum` after this will cause an error.

### C# Display Variables

I learned how to display variables together with text and how to use the `+` operator.

**`+` with strings**: Combines strings together.

**`+` with numbers**: Performs mathematical addition.

For example:

```csharp
string firstName = "John ";
string lastName = "Doe";
string fullName = firstName + lastName;
```

The result is `John Doe`.

### C# Multiple Variables

I learned how to declare and assign multiple variables in a single line.

```csharp
int x = 5, y = 6, z = 50;
```

I also learned that multiple variables can be assigned the same value:

```csharp
int x, y, z;
x = y = z = 50;
```

### C# Identifiers

I learned that variable names are called identifiers and that they should be clear and descriptive.

**Identifier:** A unique name used to identify a variable or other element in a program.

**Naming rules:**

- Names can contain letters, digits, and `_`.
- Names must start with a letter or `_`.
- Names cannot contain spaces.
- Names are case-sensitive.
- Reserved C# keywords such as `int` and `double` cannot be used as variable names.
- Variable names should normally start with a lowercase letter.
- Descriptive names such as `minutesPerHour` are recommended because they make code easier to understand.

## Exercises

1. **WriteLine and Write**
   Practiced printing multiple messages using `Console.WriteLine()` and `Console.Write()` and observed the difference between new lines and the same line.

2. **Comments**
   Practiced adding single-line (`//`) and multi-line (`/* */`) comments to C# programs.

3. **Variables and Data Types**
   Created variables using `int`, `double`, `char`, `string`, and `bool`, then displayed their values in the console.

4. **Changing Variable Values**
   Declared variables, assigned values, and reassigned new values to existing variables.

5. **Constants**
   Created a `const` variable and tested what happens when trying to change its value.

6. **Displaying and Combining Variables**
   Used the `+` operator to combine strings and to perform calculations with numeric variables.

7. **Multiple Variables**
   Created and assigned multiple variables in one line and assigned the same value to several variables.

8. **Identifiers**
   Practiced using descriptive variable names and reviewed the rules for naming C# variables.

## Next

- Learn C# Data Types
- Learn C# Type Casting
- Learn C# User Input
