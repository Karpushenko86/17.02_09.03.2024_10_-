// Задача 3.
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если первое число некратно второму, 
// то программа выводит остаток от деления.
// Примеры:
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
{
    Console.Write($"{num1}, {num2} => да");
}
else
{
    Console.WriteLine($"{num1}, {num2} => нет, {remainder}");
}

