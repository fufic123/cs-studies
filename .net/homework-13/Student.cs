using System;

public class Student
{
    public string status = "";

    public void Jump()
    {
        status = "Прыгает";
        Console.WriteLine("Прыгает");
    }

    public void Select()
    {
        status = "Выбирает";
        Console.WriteLine("Выбирает");
    }

    public void Sleep()
    {
        status = "Спит";
        Console.WriteLine(" Спит");
    }

    public void Move()
    {
        status = "Двигается";
        Console.WriteLine("Двигается");
    }

    public void ShowStatus()
    {
        Console.WriteLine("Состояние: " + status);
    }
}
