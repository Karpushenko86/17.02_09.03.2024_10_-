// Задача 3.
// Напишите программу, которая перевернёт одномерный массив. 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// Пример
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

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

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int sub = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = sub;
    }

    return array;
}

Console.Write("Введите размер массива: ");
if (int.TryParse(Console.ReadLine(), out int size))
{
    int minimum = 0;
    int maximum = 10;

    int[] array = CreateArrayRndInt(size, minimum, maximum);
    PrintArray(array);

    Console.Write("=> ");

    array = ReverseArray(array);
    PrintArray(array);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}