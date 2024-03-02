// Задача 2.
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример
// [344 452 341 125] => 2

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

int CountEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }

    return result;
}

Console.Write("Введите размер массива: ");
if (int.TryParse(Console.ReadLine(), out int size))
{
    int minimum = 100;
    int maximum = 1000;

    int[] array = CreateArrayRndInt(size, minimum, maximum);
    PrintArray(array);

    Console.Write("=> ");

    Console.Write(CountEvenNumbers(array));
}
else
{
    Console.WriteLine("Некорректный ввод!");
}

