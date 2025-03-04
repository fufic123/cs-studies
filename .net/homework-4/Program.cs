using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        string[,] numbers = new string[10, 5]
        {
            { " 000 ", "0   0", "0   0", "0   0", " 000 " }, // 0
            { "  1  ", " 11  ", "  1  ", "  1  ", " 111 " }, // 1
            { " 222 ", "    2", " 222 ", "2    ", " 222 " }, // 2
            { " 333 ", "    3", " 333 ", "    3", " 333 " }, // 3
            { "4   4", "4   4", " 444 ", "    4", "    4" }, // 4
            { " 555 ", "5    ", " 555 ", "    5", " 555 " }, // 5
            { " 666 ", "6    ", " 666 ", "6   6", " 666 " }, // 6
            { " 777 ", "    7", "   7 ", "  7  ", " 7   " }, // 7
            { " 888 ", "8   8", " 888 ", "8   8", " 888 " }, // 8
            { " 999 ", "9   9", " 999 ", "    9", " 999 " }  // 9
        };

        for (int row = 0; row < 5; row++)
        {
            foreach (char digit in input)
            {
                if (char.IsDigit(digit))
                    Console.Write(numbers[digit - '0', row] + "  ");
            }
            Console.WriteLine();
        }
    }
}
