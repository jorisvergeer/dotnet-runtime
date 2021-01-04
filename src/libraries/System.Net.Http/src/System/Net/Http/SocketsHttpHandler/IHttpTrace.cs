// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Net.Http
{
    internal interface IHttpTrace
    {
        void Trace(string message, [CallerMemberName] string? memberName = null);
    }
}
