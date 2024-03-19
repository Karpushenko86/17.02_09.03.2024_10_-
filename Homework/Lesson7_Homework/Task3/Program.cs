// Задача 3. 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// 
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

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

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write($"{array[array.Length - 1]}] ");
// }

void PrintArrayReqursion(int[] array, int count)
{
    if (count == 0 && array.Length == 1)        // Условие для массива из одного элемента
    {
        Console.Write($"{array[count]}");
        return;
    }

    if (count == 0 && array.Length > 1)         // Условие для первого эл. массива
    {
        Console.Write($"{array[count]}, ");
        return;
    }

    PrintArrayReqursion(array, count - 1);

    if (count == array.Length - 1)              // Условие для последнего эл. массива
    {
        Console.Write($"{array[count]}");
        return;
    }

    Console.Write($"{array[count]}, ");         // Вывод остальных эл. массива
}

void PrintArrayReqursionReverse(int[] array, int count)
{
    if (count == 0) 
    {
        Console.Write($"{array[count]} ");
        return;
    }

    Console.Write($"{array[count]} ");
    PrintArrayReqursionReverse(array, count - 1);
}

int minimum = 1;
int maximum = 10;

Console.Write("Введите размер массива: ");
if(int.TryParse(Console.ReadLine(), out int size))
{ 
    int[] array = CreateArrayRndInt(size, minimum, maximum);
    // PrintArray(array);
    // Console.WriteLine();
    Console.Write($"[");
    PrintArrayReqursion(array, array.Length - 1);
    Console.Write($"] => ");
    PrintArrayReqursionReverse(array, array.Length - 1);
}
else
{
    Console.WriteLine("Неверный ввод данных!");
}




