# Day 10 — C# Method Overloading

**Date:** October 14, 2026<br>
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### Method Overloading

Method overloading allows you to define multiple methods with the same name but different parameter lists. This makes it possible to perform similar actions using different data types or numbers of parameters.

For example:

```csharp
static int MyMethod(int x)
static float MyMethod(float x)
static double MyMethod(double x, double y)
```

### Using Different Method Names

You can create separate methods with different names to handle different data types.

```csharp
static int PlusMethodInt(int x, int y)
{
    return x + y;
}

static double PlusMethodDouble(double x, double y)
{
    return x + y;
}
```

In this example, `PlusMethodInt()` adds integers, while `PlusMethodDouble()` adds decimal numbers.

### Overloading a Method

Instead of using different names for methods that perform the same action, you can overload one method name.

```csharp
using System;

namespace MyApplication
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);

            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
```

**Output:**

```text
Int: 13
Double: 10.559999999999999
```

- **Same method name:** Both methods are named `PlusMethod`.
- **Different parameter types:** One method accepts `int` values, while the other accepts `double` values.
- **Method selection:** C# selects the appropriate method based on the arguments passed when calling it.

**Important:** Overloaded methods must have different parameter lists. Changing only the return type is not enough to overload a method.

## Exercises

1. **Method Overloading**<br>
   Learned how to define multiple methods with the same name but different parameter types or numbers of parameters.

## Next

- C#
- C# Classes and Objects
