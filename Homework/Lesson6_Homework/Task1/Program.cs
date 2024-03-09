// Задача 1.
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// Пример
// a b c => “abcdef”
// d e f 

static string MakeStringFrom2DCharTable(char[,] table)
{
    string result = string.Empty;

    int rows = table.GetLength(0);
    int columns = table.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result += table[i, j];
        }
    }

    return result;
}

char[,] table = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};

Console.WriteLine(MakeStringFrom2DCharTable(table));

