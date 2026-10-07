# Day 3 — C# Data Types, Type Casting, and User Input

**Date:** October 7, 2026
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Data Types

I learned that a data type specifies what kind of value a variable can store. Using the correct data type helps make code readable, maintainable, and memory-efficient.

**`int`**: Stores whole numbers.

**`long`**: Stores very large whole numbers.

**`float`**: Stores decimal numbers with about 6–7 digits of precision. Decimal values use `F`.

**`double`**: Stores decimal numbers with about 15 digits of precision.

**`bool`**: Stores either `true` or `false`.

**`char`**: Stores a single character using single quotes, such as `'A'`.

**`string`**: Stores a sequence of characters (text) using double quotes.

### Integer Numbers

I learned that integer types store whole numbers without decimal values.

**`int`**: Commonly used for normal whole numbers.

**`long`**: Used when a number is too large for an `int`.

### Floating-Point Numbers

I learned that floating-point types are used for numbers with decimal values.

**`float`**: Stores decimal numbers and uses `F` for decimal values.

**`double`**: Stores decimal numbers with greater precision than `float`.

### Scientific Numbers

I learned that floating-point values can also be written using scientific notation.

**`e` / `E`**: Represents a power of 10.

For example, `35e3F` means `35 × 10³`.

### Booleans

I learned how to use Boolean values for situations with two possible states.

**`bool`**: Can only contain `true` or `false`.

**Boolean values**: Commonly used for conditional testing.

### Characters

I learned how to store a single character.

**`char`**: Stores one character surrounded by single quotes, such as `'B'`.

### Strings

I learned how to store text.

**`string`**: Stores a sequence of characters surrounded by double quotes.

### C# Type Casting

I learned how to convert a value from one data type to another.

**Implicit casting**: Automatically converts a smaller compatible type to a larger compatible type.

`char → int → long → float → double`

**Explicit casting**: Manually converts a value to another type by putting the target type in parentheses.

```csharp
int myInt = (int)myDouble;
```

### User Input

I learned how to get input from the user through the console.

**`Console.ReadLine()`**: Reads a line of text entered by the user.

**`Convert.ToInt32()`**: Converts user input from a string to an integer.

## Exercises

1. **Data Types Exercise**

I practised creating variables with different data types, including `int`, `long`, `float`, `double`, `bool`, `char`, and `string`.

2. **Type Casting Exercise**

I practised converting values between different data types using implicit and explicit casting.

3. **User Input Exercise**

I practised getting values from the user with `Console.ReadLine()` and converting the input into numbers.

## Next

- Learn C# operators
- C# Math
- C# Strings
