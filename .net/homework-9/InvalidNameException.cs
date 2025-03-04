using System;

public class InvalidNameException : Exception
{
    public InvalidNameException(string message) : base(message) { }
}
