﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Numerics/Hashing/HashHelpers.cs

// ReSharper disable once CheckNamespace
namespace System.Numerics.Hashing;

internal static class HashHelpers
{
    public static int Combine(int h1, int h2)
    {
        // RyuJIT optimizes this to use the ROL instruction Related GitHub pull request: https://github.com/dotnet/coreclr/pull/1830
        var rol5 = ((uint)h1 << 5) | ((uint)h1 >> 27);
        return ((int)rol5 + h1) ^ h2;
    }
}