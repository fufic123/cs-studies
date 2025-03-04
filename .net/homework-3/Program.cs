using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задание (1-6): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                AverageOfThree();
                break;
            case 2:
                PowerCalculation();
                break;
            case 3:
                CurrencyConverter();
                break;
            case 4:
                KmToMilesConverter();
                break;
            case 5:
                PercentageOfNumber();
                break;
            case 6:
                TemperatureConverter();
                break;
            default:
                Console.WriteLine("Неверный ввод.");
                break;
        }
    }

    static void AverageOfThree()
    {
        Console.Write("Введите три числа через пробел: ");
        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double average = (a + b + c) / 3;
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
    

    static void PowerCalculation()
    {
        Console.Write("Введите число: ");
        double number = double.Parse(Console.ReadLine());

        Console.Write("Введите степень: ");
        double power = double.Parse(Console.ReadLine());

        double result = Math.Pow(number, power);
        Console.WriteLine($"Результат: {result}");
    }
    

    static void CurrencyConverter()
    {
        Console.Write("Введите сумму в гривнах: ");
        double uah = double.Parse(Console.ReadLine());

        double usdRate = 43.0; 
        double eurRate = 46.0;

        Console.WriteLine($"В долларах: {uah / usdRate:F2} USD");
        Console.WriteLine($"В евро: {uah / eurRate:F2} EUR");
    }
    

    static void KmToMilesConverter()
    {
        Console.Write("Введите расстояние в километрах: ");
        double km = double.Parse(Console.ReadLine());

        double landMiles = km * 0.621371;
        double nauticalMiles = km * 0.539957;

        Console.WriteLine($"Сухопутные мили: {landMiles:F2}");
        Console.WriteLine($"Морские мили: {nauticalMiles:F2}");
    }
    

    static void PercentageOfNumber()
    {
        Console.Write("Введите число N: ");
        double N = double.Parse(Console.ReadLine());

        Console.Write("Введите процент P: ");
        double P = double.Parse(Console.ReadLine());

        double result = (P / 100) * N;
        Console.WriteLine($"{P}% от {N} = {result}");
    }
    

    static void TemperatureConverter()
    {
        Console.Write("Введите температуру в градусах Цельсия: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"В Фаренгейтах: {fahrenheit:F2}°F");

        Console.Write("Введите температуру в градусах Фаренгейта: ");
        double f = double.Parse(Console.ReadLine());
        double c = (f - 32) * 5 / 9;
        Console.WriteLine($"В Цельсиях: {c:F2}°C");
    }
    
}
