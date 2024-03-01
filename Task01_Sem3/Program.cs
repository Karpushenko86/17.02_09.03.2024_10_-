// Пример
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в
// массиве. Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] array1 = new int[8];
// int[] array2 = new int[8] { 4, 6, 8, 9, 4, 4 };
// int[] array3 = new int[] { 4, 6, 8, 9, 4, 4 };

bool res = false;
int[] array4 = { 5, 6, 9, 2, 2, 9, 3, 1, 0 };

Console.Write("Задайте целое число для поиска в массиве: ");
int targetNum = Convert.ToInt32(Console.ReadLine());

Console.Write('[');
for (int i = 0; i < array4.Length; i++)
{
    if (array4[i] == targetNum)
    {
        res = true;
    }
    Console.Write($"{array4[i]} ");
}
Console.Write($"], {targetNum} => ");

// string result = res ? "Да" : "Нет"; 
Console.Write(res ? "Да" : "Нет");

