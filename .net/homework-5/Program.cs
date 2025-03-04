using System;

class Program
{
    static void Main()
    {
        Address address = new Address("Одесса", "Садовая", 3);
        int[] homework = { 10, 10, 10 };
        int[] finals = { 10, 10 };
        int[] exams = { 10, 10, 10 };

        Student student = new Student(
            "Иванов", "Иван", "Иванович", new DateTime(2000, 1, 11),
            address, "+380 99 607 85 19", homework, finals, exams
        );

        student.PrintInfo();
    }
}
