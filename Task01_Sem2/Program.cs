// Задача 1.
// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру этого числа.
// Примеры:
// a = 256=> 26
// a = 891=> 81

// Первый вариант. Через использование математических операций
Console.Write("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
// Проверка на вхождение в заданный диапозон трёхзначных чисел
if (num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    int fisrtDigit = num / 100;
    int lastDigit = num % 10;

    int result = fisrtDigit * 10 + lastDigit;
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}

// Второй вариант. Через использование Convert.ToString(VALUE)
Console.Write("Введите целое трёхзначное число: ");
int num2= Convert.ToInt32(Console.ReadLine());
// Проверка на вхождение в заданный диапозон трёхзначных чисел
if (num2 >= 100 && num2 <= 999 || num2 >= -999 && num2 <= -100)
{
    string strDigits = Convert.ToString(num2 / 100) + Convert.ToString(num2 % 10);
    Console.WriteLine($"{num2} => {strDigits}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}