using System;

class Program
{
    static void Main()
    {
        StudentKeyListener listener = new StudentKeyListener();
        Student student = new Student();

        listener.Space += student.Jump;
        listener.Enter += student.Select;
        listener.Escape += student.Sleep;
        listener.Arrows += student.Move;
        listener.F1 += student.ShowStatus;

        Console.WriteLine("Нажмите клавишу\n");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                listener.Listen(ConsoleKey.Escape);
                break;
            }

            listener.Listen(keyInfo.Key);
        }
    }
}
