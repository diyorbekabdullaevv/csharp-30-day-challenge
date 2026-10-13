# Day 9 — C# Method Parameters and Return Values

**Date:** October 13, 2026<br>
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### Parameters and Arguments

Parameters allow methods to receive information. They act as variables inside the method.

```csharp
static void MyMethod(string fname)
{
    Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
    MyMethod("Liam");
    MyMethod("Jenny");
    MyMethod("Anja");
}
```

- **Parameter:** A variable defined in a method, such as `fname`.
- **Argument:** A value passed to a method when it is called, such as `"Liam"`.

### Multiple Parameters

A method can have multiple parameters separated by commas. Each argument must match the corresponding parameter's type and position.

```csharp
static void MyMethod(string fname, int age)
{
    Console.WriteLine(fname + " is " + age);
}

static void Main(string[] args)
{
    MyMethod("Liam", 5);
    MyMethod("Jenny", 8);
    MyMethod("Anja", 31);
}
```

### Default Parameter Values

A parameter can have a default value using the equals sign (`=`). If no argument is provided for that parameter, the default value is used.

```csharp
static void MyMethod(string country = "Norway")
{
    Console.WriteLine(country);
}

static void Main(string[] args)
{
    MyMethod("Sweden");
    MyMethod("India");
    MyMethod();
    MyMethod("USA");
}
```

**Optional parameter:** A parameter with a default value. In this example, `country` is optional, and `"Norway"` is its default value.

### Return Values

A method can return a value instead of using `void`. The return type, such as `int`, specifies the type of value returned. The `return` keyword sends the result back to the calling code.

```csharp
static int MyMethod(int x, int y)
{
    return x + y;
}

static void Main(string[] args)
{
    int z = MyMethod(5, 3);
    Console.WriteLine(z);
}
```

**Output:** `8`

- **int:** Specifies that the method returns an integer.
- **return:** Sends the calculated result back to the caller.
- **void:** Indicates that the method does not return a value.

### Named Arguments

Named arguments let you pass values by specifying parameter names using the `name: value` syntax. This allows arguments to be provided in a different order.

```csharp
static void MyMethod(string child1, string child2, string child3)
{
    Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] args)
{
    MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}
```

**Output:** `The youngest child is: John`

## Exercises

1. **Method Parameters**<br>
   Practiced passing arguments to methods and using parameters inside them.

2. **Multiple Parameters**<br>
   Practiced defining methods with multiple parameters of different data types.

3. **Default Parameter Values**<br>
   Practiced using optional parameters with default values.

4. **Return Values**<br>
   Practiced returning calculated values from methods and storing results in variables.

5. **Named Arguments**<br>
   Practiced passing arguments by parameter name instead of relying on their order.

## Next

- C# Method Overloading
- C# Classes and Objects
- C# Constructors
