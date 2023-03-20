// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int HowBigZero(int kol)
{
    int[] kolArray = new int[kol];
    int j = 1;
    for (int i = 0; i < kol; i++)
    {

        Console.WriteLine($"Введите число под номером " + j + ":");
        j++;
        kolArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    int sum = 0;
    foreach (int el in kolArray)
        sum += el > 0 ? 1 : 0;

    return sum;
}

// Console.WriteLine("Введиет колличество элементов:");
// int kol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(HowBigZero(kol));

// =============================================================================

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Prompt4Numbers(string massage)
{
    Console.WriteLine(massage);
    string readInput = Console.ReadLine();
    double result = double.Parse(readInput);
    return result;
}
double b1 = Prompt4Numbers("Введите первое число: ");
double k1 = Prompt4Numbers("Введите второе число: ");
double b2 = Prompt4Numbers("Введите третье число: ");
double k2 = Prompt4Numbers("Введите четвертое число: ");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine();
Console.WriteLine($"Точка пепесечения двух линий: (" + x + "; " + y + ")");










