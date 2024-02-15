using System;

public class ExponentialSeries
{
    public static void Main(string[] args)
    {
        double x = 2.0; // Значение x для вычисления
        int terms = 10; // Количество членов ряда для вычисления
        double result = ComputeExponential(x, terms);
        Console.WriteLine("e^(-" + x + ") = " + result);
    }

    public static double ComputeExponential(double x, int terms)
    {
        double sum = 1.0; // Начальное значение суммы ряда
        double term = 1.0; // Значение первого члена ряда при s=0

        for (int s = 1; s < terms; s++)
        {
            term *= -x / s; // Рекурсивное вычисление следующего члена ряда
            sum += term; // Добавление следующего члена к сумме
        }

        return sum;
    }
}