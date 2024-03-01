// Задача 4.
// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.Write("Введите натуральное трёхзначное число: ");
if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
{
    int[] array = new int[3];
    
    int i = 0;

    Console.Write($"{number} => [");

    while(number > 0)
    {
        array[i] = number % 10;
        number /= 10;
        i += 1;
    }

    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
else
{
    Console.WriteLine("Некорретный ввод данных!");
}



