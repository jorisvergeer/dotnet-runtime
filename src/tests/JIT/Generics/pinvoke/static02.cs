// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal class Win32Interop
{
    [DllImport("kernel32", SetLastError = true)]
    public static extern bool CloseHandle(IntPtr hObject);
}


public struct Gen<T>
{
    public static int PInvokeTest()
    {
        Win32Interop.CloseHandle(IntPtr.Zero);
        return Marshal.GetLastWin32Error();
    }

    public void Dummy(T t)
    {
        Console.WriteLine(t);
    }
}

public class Test
{
    public static uint counter = 0;
    public static bool result = true;
    public static void Eval(bool exp)
    {
        counter++;
        if (!exp)
        {
            result = exp;
            Console.WriteLine("Test Failed at location: " + counter);
        }
    }

    public static int Main()
    {
        Eval(Gen<int>.PInvokeTest() == 6);
        Eval(Gen<double>.PInvokeTest() == 6);
        Eval(Gen<string>.PInvokeTest() == 6);
        Eval(Gen<object>.PInvokeTest() == 6);
        Eval(Gen<Guid>.PInvokeTest() == 6);

        if (result)
        {
            Console.WriteLine("Test Passed");
            return 100;
        }
        else
        {
            Console.WriteLine("Test Failed");
            return 1;
        }
    }
}


