// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;

namespace System.Runtime.Caching.Resources
{
    internal static class RH
    {
        public static string Format(string resource, params object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, resource, args);
        }
    }
}
