// Задание 2.
// На основе символов строки (тип string) сформировать массив символов (тип char[]). 
// Вывести массив на экран.
// 
// Указание
// Метод строки ToCharArray() не использовать.
// 
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];       // Выделяем память под массив на основе длины строки

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }

    return charsArray;
}

static void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

Console.Write("Введите вашу строку: ");
string? str = Console.ReadLine()!;
char[] chars = StringToCharArray(str);
PrintArray(chars);