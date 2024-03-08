// Задача 2.
// Напишите программу, которая принимает на вход трёхзначное число 
// и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2097152
// 254 => 5^4 = 625
// 617 => 1


Console.Write("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Проверка на вхождение в заданный диапозон трёхзначных чисел
if (num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    int secondDigit = (num / 10) % 10;
    int lastDigit = num % 10;
    
    if (secondDigit < 0)
    {
        secondDigit = -secondDigit;
    }

    if (lastDigit < 0)
    {
        lastDigit = -lastDigit;
    }

    int count = 1;
    int result = 1;
    while (count <= lastDigit)
    {
        result *= secondDigit;
        count++;
    }
    
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}