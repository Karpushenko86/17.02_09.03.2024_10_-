// Задача 4. 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Пример
// “Hello my world” => “world my Hello”

static string IsMessageString(string? message)              // Проверка на вхождение пустой строки
{
    if (message is not null)
    {
        return message;
    }

    return "";
}

static string[] GetReversedStrArray(string str)               // Перевод строки в массив строк с заменной начальных и конечных элементов между собой (разворот элементов массива)
{                                                           
    string[] strArray = str.Split();
    
    string temp = string.Empty;
    for (int i = 0; i < strArray.Length / 2; i++)
    {
        temp = strArray[i];
        strArray[i] = strArray[strArray.Length - i - 1];
        strArray[strArray.Length - i - 1] = temp;
    }

    return strArray;
}

static string GetStringFromStrArray(string[] strArray)         // Формирование строки из массива строк (получаем строку с пробелами)
{                                                           
    string result = string.Empty;
    for (int i = 0; i < strArray.Length; i++)
    {
        result += strArray[i] + " ";
    }

    return result;
}

Console.Write("Введите строку, состоящую из слов, разделенных пробелами: ");
string str = IsMessageString(Console.ReadLine());
string[] strArray = GetReversedStrArray(str);
string result = GetStringFromStrArray(strArray);
Console.Write($"{str} => {result}");
