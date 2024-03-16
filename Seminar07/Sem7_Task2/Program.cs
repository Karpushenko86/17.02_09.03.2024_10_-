// Задача 2.
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 
// Указание
// Использовать рекурсию.
// 
// Пример
// 123 => 6
// 63 => 9

int SumOfNumbers(int number)
{
    if (number == 0) return 0;

    return number % 10 + SumOfNumbers(number / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} => {SumOfNumbers(number)}");