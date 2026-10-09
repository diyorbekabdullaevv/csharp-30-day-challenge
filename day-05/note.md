# Day 5 — C# Booleans, If...Else, and Switch

**Date:** October 9, 2026
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Booleans

Booleans are used to represent one of two values: `true` or `false`.

**Boolean:** A data type declared using the `bool` keyword that stores either `true` or `false`.

```csharp
bool isDiyorbekPerfect = true;
bool isDiyorbekBad = false;
```

### Boolean Expressions

A Boolean expression compares values or variables and returns `true` or `false`.

```csharp
int x = 10;
int y = 9;
Console.WriteLine(x > y);
```

The result is `True` because 10 is greater than 9.

### Real-Life Example

Boolean expressions can be used to check conditions, such as whether someone is old enough to vote.

```csharp
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);
```

The result is `True` because the age is greater than or equal to 18.

### C# If...Else

Conditional statements allow a program to make decisions based on conditions.

**if:** Executes a block of code when a condition is `true`.

```csharp
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}
```

**else:** Executes a block of code when the `if` condition is `false`.

```csharp
int myAge = 23;

if (myAge > 23)
{
    Console.WriteLine("You are the best");
}
else
{
    Console.WriteLine("You are still the best");
}
```

**else if:** Checks another condition when the previous condition is `false`.

```csharp
int time = 22;

if (time < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
```

### Ternary Operator

The ternary operator is a shorter way to write a simple `if...else` statement.

**Ternary operator:** Uses the syntax `condition ? valueIfTrue : valueIfFalse`.

```csharp
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
```

### C# Switch

The `switch` statement selects one of several code blocks based on the value of an expression.

**switch:** Compares an expression with different `case` values and executes the matching case.

```csharp
int day = 4;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
}
```

**case:** Defines a value to match.

**break:** Exits the `switch` block after a matching case has executed.

**default:** Executes when no case matches the expression.

## Exercises

1. **Boolean Values and Expressions**
   Practiced declaring Boolean variables and comparing values to get `true` or `false` results.

2. **If Statement**
   Practiced executing code when a condition is true.

3. **If...Else Statement**
   Practiced choosing between two blocks of code based on a condition.

4. **Else If Statement**
   Practiced checking multiple conditions to select the appropriate result.

5. **Ternary Operator**
   Practiced writing simple conditional expressions in a shorter form.

6. **Switch Statement**
   Practiced selecting code blocks using `case`, `break`, and `default`.

## Next

- C# While Loop
- C# For Loop
- C# Break and Continue
