# Day 4 — C# Operators and Strings

**Date:** October 8, 2026
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Operators

Operators are used to perform operations on variables and values.

**Arithmetic Operators:** Used for common mathematical operations.

- `+` Addition — adds two values.
- `-` Subtraction — subtracts one value from another.
- `*` Multiplication — multiplies two values.
- `/` Division — divides one value by another.
- `%` Modulus — returns the remainder of a division.
- `--` Decrement — decreases a value by 1.

### Assignment Operators

Assignment operators are used to assign or update values in variables.

**Assignment Operators:** `=`, `+=`, `-=`, `*=`, `/=`, `%=`, `&=`, `|=`, `^=`, `>>=`, `<<=`

For example, `x += 3` is the same as `x = x + 3`.

### Comparison Operators

Comparison operators compare two values and return either `True` or `False`.

- `==` Equal to
- `!=` Not equal
- `>` Greater than
- `<` Less than
- `>=` Greater than or equal to
- `<=` Less than or equal to

**Boolean result:** A comparison gives a `true` or `false` result.

### Logical Operators

Logical operators are used to combine or reverse conditions.

- `&&` Logical AND — returns `true` when both conditions are true.
- `||` Logical OR — returns `true` when at least one condition is true.
- `!` Logical NOT — reverses the result.

### C# Math

The `Math` class provides methods for performing mathematical operations.

- `Math.Max(x, y)` — returns the highest value.
- `Math.Min(x, y)` — returns the lowest value.
- `Math.Sqrt(x)` — returns the square root.
- `Math.Abs(x)` — returns the absolute value.
- `Math.Round(x)` — rounds a number to the nearest whole number.

### C# Strings

Strings are used to store text.

**String:** A sequence of characters surrounded by double quotes.

```csharp
string greeting = "Hello";
```

### String Length

The `Length` property returns the number of characters in a string.

```csharp
string txt = "Hello";
Console.WriteLine(txt.Length);
```

### String Methods

C# provides methods for working with strings.

- `ToUpper()` — converts a string to uppercase.
- `ToLower()` — converts a string to lowercase.

### String Concatenation

The `+` operator can be used to combine strings. This is called concatenation.

```csharp
string firstName = "Diyorbek ";
string lastName = "Abdullaev";
string name = firstName + lastName;
```

`string.Concat()` can also be used to combine strings.

### Adding Numbers and Strings

The `+` operator can be used for both addition and string concatenation.

**Numbers:** Two numbers are added.

```csharp
int x = 10;
int y = 20;
int z = x + y;
```

**Strings:** Two strings are concatenated.

```csharp
string x = "10";
string y = "20";
string z = x + y;
```

### String Interpolation

String interpolation allows variables to be inserted directly into a string using `$` and `{}`.

```csharp
string name = $"{firstName} {lastName}";
```

### Accessing Strings

Characters in a string can be accessed using an index inside square brackets `[]`.

```csharp
string myString = "Hello";
Console.WriteLine(myString[2]);
```

**String index:** Indexes start from `0`, so `[0]` is the first character, `[1]` is the second, and so on.

### IndexOf()

The `IndexOf()` method finds the index position of a specific character or text.

```csharp
string myString = "Hello";
Console.WriteLine(myString.IndexOf("o"));
```

### C# Special Characters

The backslash `\` is used as an escape character when working with special characters inside strings.

- `\'` — single quote
- `\"` — double quote
- `\\` — backslash
- `\n` — new line
- `\t` — tab
- `\b` — backspace

**Escape character:** Allows special characters to be included correctly inside a string.

## Exercises

1. **Arithmetic Operators**
   Practiced addition, subtraction, multiplication, division, modulus, and decrement operators.

2. **Assignment Operators**
   Practiced assigning and updating variable values using operators such as `=`, `+=`, `-=`, `*=`, `/=`, and `%=`.

3. **Comparison Operators**
   Practiced comparing values using `==`, `!=`, `>`, `<`, `>=`, and `<=`.

4. **Logical Operators**
   Practiced combining conditions using `&&`, `||`, and `!`.

5. **Math Methods**
   Practiced using `Math.Max()`, `Math.Min()`, `Math.Sqrt()`, `Math.Abs()`, and `Math.Round()`.

6. **Strings**
   Practiced creating strings, checking string length, changing letter case, concatenating strings, and using string interpolation.

7. **Accessing Strings**
   Practiced accessing characters by index and finding character positions with `IndexOf()`.

8. **Special Characters**
   Practiced using escape characters such as `\"`, `\'`, `\\`, `\n`, and `\t`.

## Next

- C# Booleans
- C# If...Else
- C# Switch
