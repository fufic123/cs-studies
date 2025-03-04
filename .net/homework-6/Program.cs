using System;

class Program
{
    static void Main()
    {
        Group group1 = new Group();
        group1.ShowGroupInfo();

        Console.WriteLine("\nОтчисление неуспевающих студентов...");
        group1.ExpelFailingStudents();
        group1.ShowGroupInfo();

        Console.WriteLine("\nСоздание новой группы из старой...");
        Group group2 = new Group(group1);
        group2.GroupName = "New Group";
        group2.ShowGroupInfo();
    }
}
