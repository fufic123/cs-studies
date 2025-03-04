using System;

class Program
{
    static void Main()
    {
        Group g = new Group();
        Student s1 = new Student("Іваненко", "Іван", "Олегович", new DateTime(2003, 5, 21),
            new Address("Одеса", "Дерибасівська", 10), "+380999123456",
            new int[] { 12, 10, 9 }, new int[] { 11, 9 }, new int[] { 10, 12 });

        Student s2 = new Student("Петренко", "Петро", "Сергійович", new DateTime(2004, 8, 14),
            new Address("Одеса", "Французький бульвар", 24), "+380999654321",
            new int[] { 5, 6, 4 }, new int[] { 7, 5 }, new int[] { 6, 5 });

        g.AddStudent(s1);
        g.AddStudent(s2);

        Console.WriteLine("\nСтуденты в группе:");
        g.ShowGroupInfo();

        Console.WriteLine("\nПервый студент:");
        Console.WriteLine(g[0]);

        g[1] = new Student("Сидоренко", "Олексій", "Іванович", new DateTime(2005, 2, 10),
            new Address("Одеса", "Пушкінська", 30), "+380999111222",
            new int[] { 9, 10, 11 }, new int[] { 10, 11 }, new int[] { 12, 12 });

        Console.WriteLine("\nПосле изменения второго студента:");
        g.ShowGroupInfo();





        List<Storage> storageDevices = new List<Storage>
        {
            new Flash("Kingston", "DataTraveler", 10, 250, 128, 100),
            new DVD("Verbatim", "DVD-R", 50, 20, 16, 8),
            new HDD("Western Digital", "MyPassport", 5, 1500, 2, "USB 3.0")
        };

        Console.WriteLine("\n📋 Список носителей информации:");
        foreach (var device in storageDevices)
        {
            device.PrintInfo();
        }
    }
}
