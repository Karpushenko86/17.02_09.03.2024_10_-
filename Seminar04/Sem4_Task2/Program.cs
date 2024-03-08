// Задание 2.
// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

int FindResult(int endDigit, int numberDivide, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == endDigit && array[i] % numberDivide == 0) count++;
    }

    return count;
}

Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int minimum = 1;
int maximum = 100;

int[] array = CreateArrayRndInt(count, minimum, maximum);
PrintArray(array);

Console.Write("=> ");
Console.Write(FindResult(1, 7, array));