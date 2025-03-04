using System;

public class InvalidCourseException : Exception
{
    public InvalidCourseException(string message) : base(message) { }
}
