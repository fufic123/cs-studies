using System;

class Program
{
    static void Main()
    {
        Student s1 = new Student("Іваненко", "Іван", "Олегович", new DateTime(2003, 5, 21),
            new Address("Одеса", "Дерибасівська", 10), "+380999123456",
            new int[] { 12, 10, 9 }, new int[] { 11, 9 }, new int[] { 10, 12 });

        Student s2 = new Student("Петренко", "Петро", "Сергійович", new DateTime(2004, 8, 14),
            new Address("Одеса", "Французький бульвар", 24), "+380999654321",
            new int[] { 5, 6, 4 }, new int[] { 7, 5 }, new int[] { 6, 5 });

        Console.WriteLine($"\n{(s1 ? "✅ Студент успішний" : "❌ Студент неуспішний")}: {s1}");
        Console.WriteLine($"{(s2 ? "✅ Студент успішний" : "❌ Студент неуспішний")}: {s2}");

        Console.WriteLine($"\nСравнение {s1.LastName} и {s2.LastName}:");
        Console.WriteLine($"s1 > s2: {s1 > s2}");
        Console.WriteLine($"s1 < s2: {s1 < s2}");
        Console.WriteLine($"s1 == s2: {s1 == s2}");
        Console.WriteLine($"s1 != s2: {s1 != s2}");
    }
}
