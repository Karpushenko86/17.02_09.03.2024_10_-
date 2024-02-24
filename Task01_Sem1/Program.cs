// Задание 1. 
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Введите первое целое число 'a': ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число 'b': ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Первый способ
Console.WriteLine("Является ли первое число квадратом второго?");
if (num1 == num2 * num2)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, второе число не является квадратом второго");
}

// Второй способ
bool result2 = num1 == num2 * num2;
if (result2)
{
    Console.WriteLine($"a = {num1}, b = {num2} => {result2}");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

// Третий способ
bool result3 = num1 == num2 * num2;
string resultStr = result3 ? "да" : "нет";
Console.WriteLine($"a = {num1}, b = {num2} => {result3}");
