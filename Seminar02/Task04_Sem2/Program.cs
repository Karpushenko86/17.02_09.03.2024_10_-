// Задача 4.
// Напишите программу, которая выводит третью слева цифру 
// заданного числа или сообщает, что третьей цифры нет.
// Пример
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numLocal = num;
if (numLocal < 0) numLocal = numLocal * -1;

if (numLocal > 99)
{
    while (numLocal > 999) numLocal /= 10;
    Console.WriteLine($"{num} => {numLocal%10}");
}
else
{
    Console.WriteLine($"{numLocal} => Третьей цифры нет");
}
