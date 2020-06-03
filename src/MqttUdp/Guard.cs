using System;

class Guard
{
    public static void Assert<T>(T expected, T actual, string? message = null)
    {
        if (!Equals(expected,actual)) throw new InvalidOperationException($"Expected {actual} to be {expected}.");
    }

    public static void Assert(bool succes, string message)
    {
        if (!succes) throw new InvalidOperationException(message);
    }
}
