// Задача 3.
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// Пример
// “aBcD1ef!-”  => Нет
// “шалаш”      => Да
// “55655”      => Да

static string IsMessageString(string? message)                    // Проверка на вхождение пустой строки
{
    if (message is not null)
    {
        return message;
    }

    return "";
}

static char[] StringToCharArray(string str)                     // Перевод строки в массив символов
{
    char[] charsArray = new char[str.Length];

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }

    return charsArray;
}

static void IsStringPalindrome(string input)                    
{
    char[] charsArray = StringToCharArray(input);

    int ArrLength = charsArray.Length;

    int count = 0;
    for (int i = 0; i < ArrLength / 2; i++)
    {
        if (charsArray[i] == charsArray[ArrLength - i - 1])
        {
            continue;
        }
        else
        {
            count++;
            break;
        }
    }

    if (count > 0)
    {
        Console.Write($"{input} => Нет");
    }
    else
    {
        Console.Write($"{input} => Да");
    }
}

Console.Write("Введите произвольную строку: ");
string str = IsMessageString(Console.ReadLine());
IsStringPalindrome(str);