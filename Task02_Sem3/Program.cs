// Задание 2.
// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные
// элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6] => [-1 5 -6]

int[] array = new int[10] { 2, 7, 1, -4, 0, -1, 6, 7, 9, -2 };

Console.Write('[');
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]} ");
    array[i] *= -1;
}
Console.Write($"{array[array.Length - 1]}] => ");
array[array.Length - 1] *= -1;

Console.Write('[');
for (int j = 0; j < array.Length - 1; j++)
{
    Console.Write($"{array[j]} ");
}
Console.Write($"{array[array.Length - 1]} ]");