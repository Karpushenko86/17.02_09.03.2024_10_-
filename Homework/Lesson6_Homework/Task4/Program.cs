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

static string[] GetReversedString(string str)               // Перевод строки в массив строк с заменной начальных и конечных элементы между собой (разворот элементов массива)
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

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.Write($"{array[array.Length - 1]}");
}

Console.Write("Введите строку, состоящую из слов, разделенных пробелами: ");
string str = IsMessageString(Console.ReadLine());
string[] strArray = GetReversedString(str);
PrintArray(strArray);
