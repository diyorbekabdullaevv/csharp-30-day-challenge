# Day 8 — C# Methods

**Date:** October 12, 2026<br>
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Methods

A method is a block of code that runs when it is called. Methods are used to perform actions and reuse code without writing it multiple times.

**Method:** A reusable block of code designed to perform a specific action. Methods are also known as functions.

### Creating a Method

A method is defined using a name followed by parentheses `()` and a code block.

```csharp
static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}
```

- **MyMethod():** The name of the method.
- **static:** Means the method belongs to the class rather than an instance of the class.
- **void:** Means the method does not return a value.

### Calling a Method

To execute a method, write its name followed by parentheses `()` and a semicolon.

```csharp
static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
    MyMethod();
}
```

**Method call:** Executes the code inside the method.

### Calling a Method Multiple Times

A method can be called multiple times to repeat the same action without duplicating its code.

```csharp
static void Main(string[] args)
{
    MyMethod();
    MyMethod();
    MyMethod();
}
```

In this example, `MyMethod()` runs three times and prints the message three times.

## Exercises

1. **Create a Method**<br>
   Practiced defining a method using a name, parentheses, and a code block.

2. **Call a Method**<br>
   Practiced calling a method from `Main()` to execute its code.

3. **Call a Method Multiple Times**<br>
   Practiced calling the same method three times to reuse code and repeat an action.

## Next

- C# Method Parameters
