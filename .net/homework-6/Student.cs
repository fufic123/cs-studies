using System;
using System.Linq;

public class Student
{
    private string _lastName;
    private string _firstName;
    private string _middleName;
    private DateTime _birthDate;
    private Address _homeAddress;
    private string _phoneNumber;
    
    private int[] _homeworkGrades;
    private int[] _finalWorkGrades;
    private int[] _examGrades;

    public string LastName { get => _lastName; set => _lastName = value; }
    public string FirstName { get => _firstName; set => _firstName = value; }
    public string MiddleName { get => _middleName; set => _middleName = value; }
    public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
    public Address HomeAddress { get => _homeAddress; set => _homeAddress = value; }
    public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
    public int[] HomeworkGrades { get => _homeworkGrades; set => _homeworkGrades = value; }
    public int[] FinalWorkGrades { get => _finalWorkGrades; set => _finalWorkGrades = value; }
    public int[] ExamGrades { get => _examGrades; set => _examGrades = value; }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate,
                   Address homeAddress, string phoneNumber, int[] homeworkGrades, 
                   int[] finalWorkGrades, int[] examGrades)
    {
        _lastName = lastName;
        _firstName = firstName;
        _middleName = middleName;
        _birthDate = birthDate;
        _homeAddress = homeAddress;
        _phoneNumber = phoneNumber;
        _homeworkGrades = homeworkGrades ?? new int[0];
        _finalWorkGrades = finalWorkGrades ?? new int[0];
        _examGrades = examGrades ?? new int[0];
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate,
                   Address homeAddress, string phoneNumber)
    {
        _lastName = lastName;
        _firstName = firstName;
        _middleName = middleName;
        _birthDate = birthDate;
        _homeAddress = homeAddress;
        _phoneNumber = phoneNumber;
        _homeworkGrades = new int[0];
        _finalWorkGrades = new int[0];
        _examGrades = new int[0];
    }

    public double AverageGrade()
    {
        var allGrades = _homeworkGrades.Concat(_finalWorkGrades).Concat(_examGrades);
        return allGrades.Any() ? allGrades.Average() : 0.0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ФИО: {_lastName} {_firstName} {_middleName}");
        Console.WriteLine($"Дата рождения: {_birthDate:dd.MM.yyyy}");
        Console.WriteLine($"Адрес: {_homeAddress}");
        Console.WriteLine($"Телефон: {_phoneNumber}");
        Console.WriteLine($"Средний балл: {AverageGrade():F2}");
        Console.WriteLine($"Домашние задания: {string.Join(", ", _homeworkGrades)}");
        Console.WriteLine($"Итоговые работы: {string.Join(", ", _finalWorkGrades)}");
        Console.WriteLine($"Экзамены: {string.Join(", ", _examGrades)}");
    }
}
