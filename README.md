# Ranges
 
Range & indexing support for legacy .NET Frameworks
 
| | Description |
|---|---|
| ASSEMBLY NAME: | Ranges |
| CREATED BY: | [Latency McLaughlin] |
| UPDATED: | 10/16/2026 |
| FRAMEWORKS: | net45, net451, net452, net46, net461, net462, net47, net471, net472, net48, net481, netstandard2.0, netstandard2.1, net8.0, net9.0, net10.0, net11.0 |
| LANGUAGE: | [C#] preview |
| OUTPUT TYPE: | [Library] [API] |
| SUPPORTS: | [Visual Studio] |
| GFX SUBSYS: | [None] |
| TAGS: | [C#], [Ranges], [Indexing] |
| STATUS: | [![workflow-badge](https://github.com/Latency/Ranges/actions/workflows/status.yml/badge.svg)](https://github.com/Latency/Ranges/actions/workflows/status.yml) |
| LICENSE: | [![license-badge](https://img.shields.io/github/license/Latency/Ranges?logo=GitHub&style=plastic&logoColor=black&label=License&color=yellowgreen)](https://github.com/Latency/Ranges/blob/master/MIT-LICENSE.txt) |
| VERSION: | 1.0.11 |
 
---

## Navigation

* [Introduction](#introduction)
* [Usage](#usage)
* [Installation](#installation)
* [References](#references)
* [Report An Issue](#report-an-issue)
* [Donation](#donation)
* [License](#license)

---

## Introduction

[Ranges]

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

This library can be installed from [NuGet].

## References

[Indexing], [Ranges]

## Report An Issue

If you have a patch to contribute, a feature to request, or a bug to report, please post to the [Issue Tracker](https://github.com/Latency/Ranges/issues).

## Donation

Click the button to donate to my efforts:
[![Donate via Paypal](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG.gif)](https://paypal.me/Latency2?country.x=US&locale.x=en_US)

## License

The source code for the site is licensed under the MIT license, which you can find in the [MIT-LICENSE].txt file.

---

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job.)

   [NuGet]: <https://github.com/Latency/Ranges/pkgs/nuget/Ranges/>
   [.NET]: <https://en.wikipedia.org/wiki/.NET_Framework/>
   [Visual Studio]: <https://en.wikipedia.org/wiki/Microsoft_Visual_Studio/>
   [Library]: <https://en.wikipedia.org/wiki/Software_library/>
   [Latency McLaughlin]: <https://www.linkedin.com/in/Latency/>
   [API]: <https://en.wikipedia.org/wiki/Application_programming_interface>
   [C#]: <https://en.wikipedia.org/wiki/C_Sharp_(programming_language)>
   [DLL]: <https://en.wikipedia.org/wiki/Dynamic-link_library>
   [MIT-License]: <http://choosealicense.com/licenses/mit/>
   [WPF]: <https://en.wikipedia.org/wiki/Windows_Presentation_Foundation/>
   [WinForms]: <https://en.wikipedia.org/wiki/Windows_Forms/>
   [Unit Tests]: <https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-xunit>
   [Indexing]: <https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes>
   [Ranges]: <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/range>
