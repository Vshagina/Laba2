using System;

class Program
{
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Time
    {
        Night = 0,
        Morning = 1,
        Day = 2,
        Evening = 3
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели (от 0 до 6):");
        if (!int.TryParse(Console.ReadLine(), out int dayIn) || dayIn < 0 || dayIn > 6)
        {
            Console.WriteLine("Ошибка - некоректное число для дня недели");
            return;
        }

        Console.WriteLine("Введите текущее время (от 0 до 23):");
        if (!int.TryParse(Console.ReadLine(), out int hour) || hour < 0 || hour > 23)
        {
            Console.WriteLine("Ошибка - некоректное число для времени");
            return;
        }

        Day day = (Day)dayIn;
        Time time;

        if (hour >= 0 && hour <= 6)
            time = Time.Night;
        else if (hour >= 7 && hour <= 12)
            time = Time.Morning;
        else if (hour >= 13 && hour <= 18)
            time = Time.Day;
        else
            time = Time.Evening;

        Console.WriteLine($"Сейчас {day}, {time}");
    }
}