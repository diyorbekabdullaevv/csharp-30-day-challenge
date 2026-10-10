# Day 6 — C# For Loops, Foreach, Break, and Continue

**Date:** October 10, 2026<br>
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# For Loop

A `for` loop is used to execute a block of code repeatedly. It is useful when you know how many times you want to loop.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

**Three parts of a for loop:**

- **Initialization:** `int i = 0` — creates and initializes the variable.
- **Condition:** `i < 5` — continues the loop while the condition is true.
- **Increment:** `i++` — increases the variable by 1 after each iteration.

**Increment by 2:** You can increase a variable by a different amount, such as `i = i + 2`.

### Nested Loops

A nested loop is a loop inside another loop.

**Nested loop:** The inner loop executes completely for each iteration of the outer loop.

For example, if the outer loop runs 2 times and the inner loop runs 3 times, the inner loop executes 6 times in total.

### C# Foreach Loop

A `foreach` loop is used to go through each element in an array or another collection.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

foreach (string car in cars)
{
    Console.WriteLine(car);
}
```

**foreach:** Takes each element from the collection one at a time and executes the code block for it.

### C# Break

The `break` statement immediately stops a loop when a specified condition is met.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }

    Console.WriteLine(i);
}
```

The loop stops when `i` becomes `4`, so the number `4` is not printed.

### C# Continue

The `continue` statement skips the current iteration and moves to the next iteration of the loop.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

The number `4` is skipped, but the loop continues with the remaining numbers.

### Break and Continue in While Loops

Both `break` and `continue` can also be used in `while` loops.

- **break:** Stops the loop completely.
- **continue:** Skips the current iteration and continues with the next one.

When using `continue` in a `while` loop, make sure the loop variable is updated correctly to avoid an infinite loop.

## Exercises

1. **For Loop**<br>
   Practiced repeating code using initialization, conditions, and incrementing.

2. **Increment by 2**<br>
   Practiced printing numbers in steps of 2 using a `for` loop.

3. **Nested Loops**<br>
   Practiced placing one loop inside another and observing how many times each executes.

4. **Foreach Loop**<br>
   Practiced iterating through an array of car names and printing each element.

5. **Break Statement**<br>
   Practiced stopping a loop when a specified condition was met.

6. **Continue Statement**<br>
   Practiced skipping a specific iteration while allowing the loop to continue.

7. **Break and Continue in While Loops**<br>
   Practiced controlling `while` loops using `break` and `continue`.

## Next

- C# Arrays
- C# Methods
