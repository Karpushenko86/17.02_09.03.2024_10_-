// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Пример
// a=50 => нет
// a=7 => нет
// a=322 => да
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write($"a = {num} => да");
}
else
{
    Console.Write($"a = {num} => нет");
}
*/

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Пример
//  2,  3 => 1
// -5,  3 => 2
// -3, -2 => 3
//  4, -2 => 4
/*
Console.Write("Введите координаты точки по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = 0;
if (x != 0 && y != 0)
{
    if (x > 0)
    {
        result = 14;
    }
    else
    {
        result = 23;
    }

    if (y > 0)
    {
        result = result / 10; 
    }
    else
    {
        result = result % 10; 
    }

    Console.Write($"{x}, {y} => {result}");
}
else
{
    Console.Write("Точка лежит на координатной оси!");
}
*/

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Пример
// 40 => 4
// 96 => 9
// 72 => 7
/*
Console.Write("Введите целое число: ");
if (int.TryParse(Console.ReadLine(), out int number) && number > 9 && number < 100)
{
    int max = 0;
    int numberLocal = number;
    while (numberLocal > 0)
    {
        if ((numberLocal % 10) > max) max = numberLocal % 10;
        numberLocal /= 10;
    } 

    Console.Write($"{number} => {max}");
}
else
{
    Console.Write("Число не соответствует заданному диапазону!");
}
*/

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Пример
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2
/*
Console.Write("Введите целое число: ");
if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
{
    Console.Write($"{number} => ");

    string revStrNumber = "";
    int numberLocal = number;
    while (numberLocal > 0)
    {
        revStrNumber = revStrNumber + Convert.ToString(numberLocal % 10);  
        numberLocal /= 10;
    } 

    int reversedNumber = Convert.ToInt32(revStrNumber);
    while (reversedNumber > 9)
    {
        Console.Write($"{reversedNumber % 10}, ");
        reversedNumber /= 10;
    }

    Console.Write($"{reversedNumber % 10}"); 
}
else
{
    Console.Write("Число не соответствует заданному диапазону!");    
}
*/
// Второй способ реализации Задача 4.
/*
Console.WriteLine("Введите натуральное число N:");
int number = Convert.ToInt32(Console.ReadLine());

string digits = "";
int newNumber = number;

while (newNumber > 0)
{
    int digit = newNumber % 10;
    digits = digit + (digits == "" ? "" : ",") + digits;
    newNumber /= 10;
}

Console.WriteLine($"{number} => {digits}");
*/
