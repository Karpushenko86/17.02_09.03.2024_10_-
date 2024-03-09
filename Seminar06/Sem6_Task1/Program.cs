// Задание 1.
// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива.
// Указание конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string GetStringFormCharArray(char[] chars)
{
    string str = string.Empty;      // Присвоение пустой строки [ string.Empty <=равносильно=> "" ]

    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i] + " ";
    }

    return str;
}

char[] charsArray = {'a', 'b', 'c', 'd'};
Console.WriteLine(GetStringFormCharArray(charsArray));