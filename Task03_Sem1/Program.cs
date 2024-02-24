// Задача 3*.
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Идеальное решение.
Console.Write("Введите трёхзначное целое число: ");
// Стандартная проверка на типизацию и вхождение в заданный диапозон трёхзначных чисел
if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
{
    // Реализация суммирования первой и последней цифры в числе
    int sum = number % 10 + number / 100;
    // Вывод результата с помощью интерполяции строк
    Console.WriteLine($"{number} => {sum}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}

// Решение с Семинара.
Console.Write("Введите трёхзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Проверка на отрицательные значения
int numCheck = num;
if (num < 0) numCheck = -num;

// Проверка на вхождение в заданный диапозон трёхзначных чисел
if (numCheck >= 100 && numCheck <= 999)
{
    int sumDigits = numCheck / 100 + numCheck % 10;
    Console.WriteLine($"{num} => {sumDigits}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}