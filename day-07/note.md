# Day 7 — C# Arrays

**Date:** October 11, 2026<br>
**Time:** 1 hour

## Table of Contents

- [Learnings](#learnings)
- [Exercises](#exercises)
- [Next](#next)

## Learnings

### C# Arrays

Arrays are used to store multiple values of the same type in a single variable.

**Array declaration:** Use square brackets `[]` after the data type to declare an array.

```csharp
int[] myNum = {9, 23, 2006};
```

### Accessing Array Elements

Each element in an array has an index that can be used to access its value.

**Array index:** Indexes start at `0`, so `[0]` is the first element, `[1]` is the second, and so on.

```csharp
string[] cars = {"BMW", "Ford", "Chevrolet"};
Console.WriteLine(cars[2]);
```

### Changing Array Elements

You can change an array element by assigning a new value to its index.

```csharp
cars[0] = "Opel";
```

### Array Length

The `Length` property returns the total number of elements in an array.

```csharp
Console.WriteLine(cars.Length);
```

### Creating Arrays in Different Ways

Arrays can be created using the `new` keyword or by assigning values directly.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```

You can also specify the array size first and assign values later.

### Looping Through Arrays

You can use `for` and `foreach` loops to access every element in an array.

**for loop:** Uses a counter and the `Length` property to iterate through the array.

```csharp
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
```

**foreach loop:** Iterates through each element without requiring a counter.

```csharp
foreach (string car in cars)
{
    Console.WriteLine(car);
}
```

### Sorting Arrays

The `Array.Sort()` method sorts array elements alphabetically or in ascending order, depending on the data type.

```csharp
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
```

### System.Linq Namespace

The `System.Linq` namespace provides useful methods for working with arrays and collections.

- `Max()` — returns the largest value.
- `Min()` — returns the smallest value.
- `Sum()` — returns the sum of all values.

```csharp
using System.Linq;

int[] myNumbers = {5, 1, 8, 9};

Console.WriteLine(myNumbers.Max());
Console.WriteLine(myNumbers.Min());
Console.WriteLine(myNumbers.Sum());
```

### C# Multidimensional Arrays

A multidimensional array stores data across multiple dimensions. A two-dimensional array (2D) organizes elements into rows and columns.

```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
```

### Accessing and Changing 2D Array Elements

To access an element in a 2D array, use two indexes: one for the row and one for the column.

```csharp
Console.WriteLine(numbers[0, 2]);

numbers[0, 0] = 5;
```

Indexes start at `0`. The first index represents the row, and the second represents the column.

### Looping Through 2D Arrays

You can use a `foreach` loop to access every element in a 2D array.

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

You can also use nested `for` loops to access each row and column individually.

**GetLength():** Returns the size of a specific dimension. `GetLength(0)` returns the number of rows, while `GetLength(1)` returns the number of columns.

```csharp
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}
```

## Exercises

1. **Create an Array**<br>
   Practiced declaring arrays and storing multiple values in a single variable.

2. **Access Array Elements**<br>
   Practiced accessing individual elements using their index numbers.

3. **Change Array Elements**<br>
   Practiced updating array values using indexes.

4. **Array Length**<br>
   Practiced finding the number of elements using the `Length` property.

5. **Create Arrays in Different Ways**<br>
   Practiced creating arrays using different declarations and the `new` keyword.

6. **Loop Through Arrays**<br>
   Practiced using `for` and `foreach` loops to print array elements.

7. **Sort Arrays**<br>
   Practiced sorting string and integer arrays using `Array.Sort()`.

8. **Array Methods**<br>
   Practiced finding the maximum, minimum, and sum of array values using `Max()`, `Min()`, and `Sum()`.

9. **Multidimensional Arrays**<br>
   Practiced creating 2D arrays, accessing and changing elements, and iterating through rows and columns.

## Next

- C# Methods
