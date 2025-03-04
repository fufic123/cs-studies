using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            Student s1 = new Student("Іваненко", "Іван", "Олегович", new DateTime(2003, 5, 21),
                new Address("Одеса", "Дерибасівська", 10), "+380999123456",
                new int[] { 12, 10, 9 }, new int[] { 11, 9 }, new int[] { 10, 12 });

            Student s2 = new Student("Петренко", "Петро", "Сергійович", new DateTime(2004, 8, 14),
                new Address("Одеса", "Французький бульвар", 24), "+380999654321",
                new int[] { 5, 6, 4 }, new int[] { 7, 5 }, new int[] { 6, 5 });

            Student s3 = new Student("Сидоренко", "Олексій", "Іванович", new DateTime(2005, 2, 10),
                new Address("Одеса", "Пушкінська", 30), "+380999111222",
                new int[] { 9, 10, 11 }, new int[] { 10, 11 }, new int[] { 12, 12 });

            List<Student> students = new List<Student> { s1, s2, s3 };
            Group group1 = new Group(students, "ІТ-101", "Програмування", 2);

            Console.WriteLine("\n🏫 Група перед змінами:");
            group1.ShowGroupInfo();

            Student newStudent = new Student("Кузьменко", "Дмитро", "Павлович", new DateTime(2003, 9, 1),
                new Address("Одеса", "Соборна площа", 12), "+380999333444",
                new int[] { 8, 8, 9 }, new int[] { 7, 8 }, new int[] { 9, 10 });

            group1.AddStudent(newStudent);
            Console.WriteLine("\n🎓 Додали студента:");
            group1.ShowGroupInfo();

            Console.WriteLine("\n✏️ Змінюємо дані студента...");
            group1.EditStudent(1, new Student("Петренко", "Павло", "Андрійович", new DateTime(2004, 1, 10),
                new Address("Одеса", "Вулиця Балківська", 5), "+380999555666",
                new int[] { 12, 12, 11 }, new int[] { 12, 12 }, new int[] { 12, 12 }));

            Console.WriteLine("\n📌 Після зміни даних студента:");
            group1.ShowGroupInfo();

            Group group2 = new Group(new List<Student>(), "ІТ-102", "Кібербезпека", 3);

            Console.WriteLine("\n🔄 Переводимо студента...");
            group1.TransferStudent(group2, 2);

            Console.WriteLine("\n📌 Група 1 після переводу:");
            group1.ShowGroupInfo();

            Console.WriteLine("\n📌 Група 2 після переводу:");
            group2.ShowGroupInfo();

            Console.WriteLine("\n⛔ Відрахування найслабшого студента...");
            group1.ExpelWorstStudent();
            group1.ShowGroupInfo();

            Console.WriteLine("\n⚠️ Відрахування студентів з низькою успішністю...");
            group1.ExpelFailingStudents();
            group1.ShowGroupInfo();

            Console.WriteLine("\n🚨 Перевіряємо обробку виключень...");
            try
            {
                Student invalidStudent = new Student("", "Іван", "Олегович", new DateTime(2003, 5, 21),
                    new Address("Одеса", "Ланжерон", 10), "+380999777888", new int[] { }, new int[] { }, new int[] { });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка створення студента: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"🔥 Загальна помилка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n✅ Програма завершена.");
        }
    }
}
