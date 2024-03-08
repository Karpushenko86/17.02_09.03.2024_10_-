// Задача 3.
// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int ArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result = result * 10 + array[i];
    }

    return result;
}

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

int min = 0;
int max = 10;
Console.Write("Введите размер массива (от 0 до 9): ");
if(int.TryParse(Console.ReadLine(), out int size) && size > min && size < max)
{ 
    int[] array = new int[size];
    array = CreateArrayRndInt(size, min, max);
    PrintArray(array);
    Console.Write("=> ");
    Console.Write(ArrayToInteger(array));
}
else
{
    Console.WriteLine("Некорректный ввод!");
}
