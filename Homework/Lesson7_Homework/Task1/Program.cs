// Задача 1. 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// 
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ShowNaturalNumbers(int num1, int num2)
{
    if (num1 == num2 + 1) return;

    if (num1 < 1 && num2 < 1) 
    {
        // Проверка диапазона на не соблюдение условия задачи
        Console.WriteLine("В заданном диапазоне нету натуральных чисел!");
        return;
    }

    if (num1 > 0)
    {
        // Если число не отрицательное, продолжаем вызов рекурсии с выводом
        Console.Write($"{num1} ");
        ShowNaturalNumbers(num1 + 1, num2);
    }
    else                
    {
        // Если число отрицательное, продолжаем вызов рекурсии без вывода
        ShowNaturalNumbers(num1 + 1, num2);
    }
}

Console.Write("Введите числовое значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите числовое значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} -> ");

if (M > N)  
{
    ShowNaturalNumbers(N, M);
}
else
{
    ShowNaturalNumbers(M, N);
}




