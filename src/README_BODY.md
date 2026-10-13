---

## Navigation

• [Introduction](#introduction)
• [Usage](#usage)
• [Installation](#installation)
• [License](#license)

---

## Introduction

[Ranges](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges)

This repository provides implementations (copied from corefx) of `System.Index` and `System.Range` for legacy .NET Frameworks.

C# 8.0 introduced the index (^) and range (..) operators to simplify accessing single elements and slices in arrays and collections.
See also [index and range features](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges)

For projects that target `netstandard2.0` or `.NET Framework 4.6.2` or later, use the [Microsoft.Bcl.Memory](https://www.nuget.org/packages/Microsoft.Bcl.Memory/), which should already be included in the netstandard2.0+ / NET Core frameworks.

• This library shall be considered deprecated and only relevant for legacy targeted frameworks.
• This library is not necessary nor recommended when targeting versions of .NET that include the relevant support.

## Usage

# Index Operator (^)

The caret (^) counts positions from the end of a sequence rather than the start:
• ^1 is the last element (50)
• ^2 is the second-to-last element (40)
• ^0 points to the length of the array (accessing numbers[^0] throws an IndexOutOfRangeException, just like numbers[length])

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine(numbers[0]);    // Output: 10 (first element)
Console.WriteLine(numbers[^1]);   // Output: 50 (last element)
Console.WriteLine(numbers[^2]);   // Output: 40 (second-to-last element)
```

# Range Operator (..)

```csharp
int[] slice = numbers[1..4]; 
// Extracts elements from index 1 up to, but not including, index 4
// Result: { 20, 30, 40 }
```

The double-dot (..) extracts a subset (slice) of a collection.
• Start index is inclusive (the item at this position is included).
• End index is exclusive (the item at this position is not included).

## Installation

This library can be installed using NuGet found [here](https://www.nuget.org/packages/Ranges/).

## License

The source code for the site is licensed under the MIT license, which you can find in
the [MIT-LICENSE].txt file.

---

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job.)

   [GNU LESSER GENERAL PUBLIC LICENSE]: <http://www.gnu.org/licenses/lgpl-3.0.en.html>
   [MIT-License]: <http://choosealicense.com/licenses/mit/>