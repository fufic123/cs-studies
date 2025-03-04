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

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Фамилия не может быть пустой.");
            _lastName = value;
        }
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя не может быть пустым.");
            _firstName = value;
        }
    }

    public string MiddleName { get => _middleName; set => _middleName = value; }
    public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
    public Address HomeAddress { get => _homeAddress; set => _homeAddress = value; }
    public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

    public int[] HomeworkGrades
    {
        get => _homeworkGrades;
        set
        {
            if (value.Any(g => g < 2 || g > 12))
                throw new ArgumentException("Оценки должны быть в диапазоне 2-12.");
            _homeworkGrades = value;
        }
    }

    public int[] FinalWorkGrades
    {
        get => _finalWorkGrades;
        set
        {
            if (value.Any(g => g < 2 || g > 12))
                throw new ArgumentException("Оценки должны быть в диапазоне 2-12.");
            _finalWorkGrades = value;
        }
    }

    public int[] ExamGrades
    {
        get => _examGrades;
        set
        {
            if (value.Any(g => g < 2 || g > 12))
                throw new ArgumentException("Оценки должны быть в диапазоне 2-12.");
            _examGrades = value;
        }
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate,
                   Address homeAddress, string phoneNumber, int[] homeworkGrades,
                   int[] finalWorkGrades, int[] examGrades)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthDate = birthDate;
        HomeAddress = homeAddress;
        PhoneNumber = phoneNumber;
        HomeworkGrades = homeworkGrades ?? new int[0];
        FinalWorkGrades = finalWorkGrades ?? new int[0];
        ExamGrades = examGrades ?? new int[0];
    }

    public double AverageGrade()
    {
        var allGrades = _homeworkGrades.Concat(_finalWorkGrades).Concat(_examGrades);
        return allGrades.Any() ? allGrades.Average() : 0.0;
    }

    public double HomeworkAverage => HomeworkGrades.Any() ? HomeworkGrades.Average() : 0.0;

    public static bool operator ==(Student s1, Student s2) => s1.AverageGrade() == s2.AverageGrade();
    public static bool operator !=(Student s1, Student s2) => !(s1 == s2);
    public static bool operator >(Student s1, Student s2) => s1.AverageGrade() > s2.AverageGrade();
    public static bool operator <(Student s1, Student s2) => s1.AverageGrade() < s2.AverageGrade();
    public static bool operator >=(Student s1, Student s2) => s1.AverageGrade() >= s2.AverageGrade();
    public static bool operator <=(Student s1, Student s2) => s1.AverageGrade() <= s2.AverageGrade();

    public static bool operator true(Student s) => s.AverageGrade() >= 7;
    public static bool operator false(Student s) => s.AverageGrade() < 7;

    public override bool Equals(object obj)
    {
        if (obj is Student other)
            return this == other;
        return false;
    }

    public override int GetHashCode() => AverageGrade().GetHashCode();

    public override string ToString()
    {
        return $"{LastName} {FirstName}, Средний балл: {AverageGrade():F2}\n" +
               $"📚 ДЗ: {string.Join(", ", _homeworkGrades)}\n" +
               $"📖 Итоговые работы: {string.Join(", ", _finalWorkGrades)}\n" +
               $"📝 Экзамены: {string.Join(", ", _examGrades)}";
    }
}
