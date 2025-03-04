using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Іваненко", "Іван", "Олегович", new DateTime(2003, 5, 21), null, "+380999123456",
                new int[] { 10, 9, 8 }, new int[] { 10, 10 }, new int[] { 12, 11 }),
            new Student("Петренко", "Петро", "Сергійович", new DateTime(2004, 8, 14), null, "+380999654321",
                new int[] { 7, 6, 5 }, new int[] { 6, 5 }, new int[] { 6, 5 }),
            new Student("Сидоренко", "Олексій", "Іванович", new DateTime(2005, 2, 10), null, "+380999111222",
                new int[] { 11, 10, 12 }, new int[] { 10, 12 }, new int[] { 12, 12 })
        };

        Console.WriteLine("\n📊 Sorting by Average Grade:");
        students.Sort();
        students.ForEach(Console.WriteLine);

        Console.WriteLine("\n🔠 Sorting by Last Name:");
        students.Sort(new Student.StudentComparerByLastName());
        students.ForEach(Console.WriteLine);
    }
}
