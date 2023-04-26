// Задача 1: ------------------------------------------------------------------------------------------------------------------
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbers(int numbers)
{
    int count = 0;
    int num = 0;
    for (int i = 1; i <= numbers; i++)
    {
        Console.Write($"Число {i}: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            count++;
    }
    return count;
}

// Console.WriteLine("Введите количество чисел: ");
// int numCount = Convert.ToInt32(Console.ReadLine());
// int count = CountPositiveNumbers(numCount);
// Console.WriteLine($"Числа > 0 : {count}");


// Задача 2: ------------------------------------------------------------------------------------------------------------------ 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoints(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координата х: {x}, координата у: {y}");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoints(b1, k1, b2, k2);