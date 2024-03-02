// Задача 1.
// Задайте одномерный массив, заполненный случайными числами. 
// Определитеколичество простых чисел вэтом массиве.
// Примеры
// [1 34 193] => 2
// [4 341 9521 13] => 3

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

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int num = array[i];
        if (IsPrimeNumber(num)) count++;
    }

    return count;
}

static bool IsPrimeNumber(int number)
{
    for (int i = 2; i < Math.Sqrt(number); i++)
    {
        if (number % i == 0) 
        {
            return false;
        }
    }

    return true;
}

int count = 10;
int minimum = 1;
int maximum = 100;

int[] array = CreateArrayRndInt(count, minimum, maximum);
PrintArray(array);

Console.Write("=> ");

int countPrimeNumbers = CountPrimeNumbers(array);
Console.Write(countPrimeNumbers);

// Console.WriteLine();
// int[] array2 = CreateArrayRndInt(20, 25, 500);
// PrintArray(array2);

// Console.WriteLine();
// int[] array3 = CreateArrayRndInt(6, 3, 9);
// PrintArray(array3);