// Задача 2. 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Пример
// “aBcD1ef!-” => “abcd1ef!-” 

using System;

static string IsMessageString(string? input)                    // Проверка на вхождение пустой строки
{
    if (input is not null)
    {
        return input;
    }

    return "";
}

static char[] StringToCharArray(string str)                     //  Перевод строки в массив символов
{
    char[] charsArray = new char[str.Length];

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }

    return charsArray;
}

static string GetCharArrayToLowerString(char[] charsArray)      //  Перевод массива символов в строку, понижая регистр символов
{
    string result = string.Empty;

    for (int i = 0; i < charsArray.Length; i++)
    {
        char currentChar = char.ToLower(charsArray[i]);

        result += currentChar;
    }

    return result;
}

Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах: ");
string str = IsMessageString(Console.ReadLine());
char[] charsArray = StringToCharArray(str);
str = GetCharArrayToLowerString(charsArray);
Console.WriteLine(str);
