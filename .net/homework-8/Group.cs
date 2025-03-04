using System;
using System.Collections.Generic;
using System.Linq;

public class Group
{
    private List<Student> _students;
    private string _groupName;
    private string _specialization;
    private int _courseNumber;

    public string GroupName
    {
        get => _groupName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Название группы не может быть пустым.");
            _groupName = value;
        }
    }

    public string Specialization
    {
        get => _specialization;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Специализация не может быть пустой.");
            _specialization = value;
        }
    }

    public int CourseNumber
    {
        get => _courseNumber;
        set
        {
            if (value < 1 || value > 6)
                throw new ArgumentException("Курс должен быть от 1 до 6.");
            _courseNumber = value;
        }
    }

    public List<Student> Students => _students;

    public Group()
    {
        _groupName = "Default Group";
        _specialization = "Computer Science";
        _courseNumber = 1;
        _students = GenerateRandomStudents(10);
    }

    public Group(List<Student> students, string groupName, string specialization, int courseNumber)
    {
        _students = new List<Student>(students);
        GroupName = groupName;
        Specialization = specialization;
        CourseNumber = courseNumber;
    }

    public Group(Group other)
    {
        _students = new List<Student>(other._students);
        _groupName = other._groupName;
        _specialization = other._specialization;
        _courseNumber = other._courseNumber;
    }

    public void ShowGroupInfo()
    {
        Console.WriteLine($"Группа: {_groupName} | Специализация: {_specialization} | Курс: {_courseNumber}");
        Console.WriteLine("Список студентов:");

        var sortedStudents = _students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
        for (int i = 0; i < sortedStudents.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sortedStudents[i]}");
        }
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
        Console.WriteLine($"Студент {student.LastName} {student.FirstName} добавлен в группу {_groupName}.");
    }

    public void EditStudent(int index, Student newStudent)
    {
        if (index >= 0 && index < _students.Count)
        {
            _students[index] = newStudent;
            Console.WriteLine($"Студент с номером {index + 1} был обновлён.");
        }
        else
        {
            Console.WriteLine("Некорректный индекс.");
        }
    }

    public void TransferStudent(Group targetGroup, int studentIndex)
    {
        if (studentIndex >= 0 && studentIndex < _students.Count)
        {
            Student student = _students[studentIndex];
            targetGroup.AddStudent(student);
            _students.RemoveAt(studentIndex);
            Console.WriteLine($"Студент {student.LastName} {student.FirstName} переведён в группу {targetGroup.GroupName}.");
        }
        else
        {
            Console.WriteLine("Некорректный индекс.");
        }
    }

    public void ExpelFailingStudents()
    {
        int countBefore = _students.Count;
        _students = _students.Where(s => s.AverageGrade() >= 3.0).ToList();
        int countAfter = _students.Count;

        Console.WriteLine($"Отчислено {countBefore - countAfter} студентов.");
    }

    public void ExpelWorstStudent()
    {
        if (_students.Count > 0)
        {
            Student worstStudent = _students.OrderBy(s => s.AverageGrade()).First();
            _students.Remove(worstStudent);
            Console.WriteLine($"Студент {worstStudent.LastName} {worstStudent.FirstName} отчислен как самый слабый.");
        }
    }

    private List<Student> GenerateRandomStudents(int count)
    {
        string[] firstNames = { "Иван", "Петр", "Мария", "Анна", "Дмитрий", "Сергей" };
        string[] lastNames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов" };
        Random random = new Random();

        return Enumerable.Range(1, count)
            .Select(_ => new Student(
                lastNames[random.Next(lastNames.Length)],
                firstNames[random.Next(firstNames.Length)],
                "Батькович",
                new DateTime(random.Next(2000, 2008), random.Next(1, 12), random.Next(1, 28)),
                new Address("Одесса", "Садовая", random.Next(1, 100)),
                "+380999999999",
                new int[] { random.Next(2, 12), random.Next(2, 12) },
                new int[] { random.Next(2, 12), random.Next(2, 12) },
                new int[] { random.Next(2, 12), random.Next(2, 12) }
            )).ToList();
    }
}
