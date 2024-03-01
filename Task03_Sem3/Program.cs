// Задание 3.
// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array  = { 1, 3, 2, 4, 2, 3 };
int[] newArray = new int[array.Length / 2];

// Для первого Массива = [1 3 2 4 2 3]
// Отрисовка массива до знака '=>' - Завершение отрисовки после знака '=>'
Console.Write('[');
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write($"{array[array.Length - 1]}] => [");

for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
    Console.Write(i == array.Length / 2 - 1 ? $"{newArray[i]}]" : $"{newArray[i]} ");   // Тернарный оператор
}

// Для второго Массива = [2 3 1 7 5 6 3]
// Отрисовка массива до знака '=>' - Завершение отрисовки после знака '=>'
int[] array2 = { 2, 3, 1, 7, 5, 6, 3 };
int[] newArray2 = new int[array2.Length / 2];

Console.WriteLine();

Console.Write('[');
for (int i = 0; i < array2.Length - 1; i++)
{
    Console.Write($"{array2[i]} ");
}
Console.Write($"{array2[array2.Length - 1]}] => [");

for (int i = 0; i < array2.Length / 2; i++)
{
    newArray2[i] = array2[i] * array2[array2.Length - 1 - i];
    Console.Write(i == array2.Length / 2 - 1 ? $"{newArray2[i]}]" : $"{newArray2[i]} ");    // Тернарный оператор
}
