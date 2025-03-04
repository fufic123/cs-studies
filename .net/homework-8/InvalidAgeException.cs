using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
