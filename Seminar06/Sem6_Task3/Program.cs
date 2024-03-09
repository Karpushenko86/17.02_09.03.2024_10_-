// Задача 3.
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.
// 
// Пример
// “hello” => 2
// “world” => 1

static int CountVowelsCharsInString(string input)
{
    int count = 0;
    string vowels = "eyuioaj";

    for (int i = 0; i < input.Length; i++)
    {
        char currentChar = input[i];
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == currentChar) count++;
        }
    }

    return count;
}

Console.Write("Введите вашу строку: ");
string? str = Console.ReadLine()!;
Console.WriteLine(CountVowelsCharsInString(str));