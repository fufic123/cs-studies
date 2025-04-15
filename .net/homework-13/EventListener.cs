using System;

public class StudentKeyListener
{
    public event Action Space;
    public event Action Enter;
    public event Action Escape;
    public event Action F1;
    public event Action Arrows;

    public void Listen(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.Spacebar:
                Space?.Invoke();
                break;
            case ConsoleKey.Enter:
                Enter?.Invoke();
                break;
            case ConsoleKey.Escape:
                Escape?.Invoke();
                break;
            case ConsoleKey.F1:
                F1?.Invoke();
                break;
            case ConsoleKey.LeftArrow:
            case ConsoleKey.RightArrow:
            case ConsoleKey.UpArrow:
            case ConsoleKey.DownArrow:
                Arrows?.Invoke();
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
}
