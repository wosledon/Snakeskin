﻿namespace Snakeskin.Exceptions;

internal class SnakeskinException : Exception
{
    public SnakeskinException(string? message = null, Exception? ex = null) : base(message, ex)
    {
    }
}

internal class SnakeskinOutOfRangeException : SnakeskinException
{
    public SnakeskinOutOfRangeException(string? message = null, Exception? ex = null) : base(message, ex)
    {
    }
}