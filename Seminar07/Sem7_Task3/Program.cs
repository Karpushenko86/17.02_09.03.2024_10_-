// Задание 3. 
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// 
// Указание
// Использовать рекурсию. Не использовать цикл.
// 
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void ShowConsonantsInString(string? str)
{
    string vowels = "eyuioaj";

    if (str.Length == 0 || str == string.Empty) return;

    if (!vowels.Contains(str[0])) 
    {
        Console.Write($"{str[0]} ");
    }

    ShowConsonantsInString(str.Substring(1));
}

Console.Write("Введите строку, содержащую латинские буквы: ");
string? str = Console.ReadLine();

Console.Write($"“{str}” => ");
ShowConsonantsInString(str);