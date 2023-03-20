// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Prompt()
{
    Console.WriteLine("int numbrer: ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
    return array;
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

// const int SIZE = 8;
// int[] array = GenerateArray(Prompt());           !!!!!!!!!!!!!
// Console.WriteLine(String.Join(",", array));
// Console.WriteLine(String.Join(",", ReverseArray(array)));

// =======================================================================================

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Prompt3Numbers(string massage)
{
    Console.WriteLine(massage);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

// int a = Prompt3Numbers("Введите первое число: ");
// int b = Prompt3Numbers("Введите второе число: ");
// int c = Prompt3Numbers("Введите третье число: ");

// if (b + c > a && c + a > b && b + a > c)
//      Console.WriteLine("Такой треугольник существует");
// else Console.WriteLine("Такого треугольника не существует");



// ==================================================================================================
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.




string TenToTwo(int num)
{
    string firstResult = " ";
    while (num > 0)
    {
        string result = Convert.ToString(num % 2);
        result = result + firstResult;
        firstResult = result;
        num /= 2;
    }
    return firstResult;
}

string input = " ";
int num = 12;
while (num > 0)
{
    input += num % 2;
    num /= 2;
}


// Console.WriteLine(input);

string Reverse(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// Console.WriteLine(Reverse(input));

// ======================================================================
// Fibonacci
//  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// int numF = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[numF];
// array[0] = 0;
// array[1] = 1;
// Console.Write(array[0] + " " + array[1]);
// for (int i = 2; i < numF; i++)
// {
//     array[i] = array[i - 1] + array[i - 2];
//     Console.Write(" " + array[i]);
// }

// =========================================================================


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];
Console.WriteLine("Первый массив: ");
for(int i = 0; i < 5; i++)
    array[i] = new Random().Next(1, 11);


for(int i = 0; i < 5; i++)
    Console.Write(array[i] + " ");

Console.WriteLine();
Console.WriteLine("Второй массив: ");

int [] array2 = new int [array.Length];
for(int i = 0; i < 5; i++)
{
    array2[i] = array[i];
    Console.Write(array[i] + " ");
}
