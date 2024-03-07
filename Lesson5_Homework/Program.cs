// Задача 4*: 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива 
// без строки и столбца
// Пример
// 4 3 1    =>    2 6
// 2 6 9          4 6
// 4 6 2


int[,] DeleteRowInMatrix(int[,] matrix, int[] minIndex)      // Возвращает Матрицу без строки
{
    // 3х3 => 2x3
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1);

    int[,] localMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            localMatrix[i, j] = matrix[];   // Надо попробовать что-то сделать с индексами matrix
        }
    }

    return localMatrix;
}

int[,] DeleteColumnInMatrix(int[,] matrix, int[] minIndex)   // Возвращает Матрицу без колонны
{
    // 2х3 => 2x2
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1) - 1;

    int[,] localMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            localMatrix[i, j] = matrix[];   // Надо попробовать что-то сделать с индексами matrix
        }
    }

    return localMatrix;
}

int[] FindIndexOfMinInMatrix(int[,] matrix)             // Возвращает Массив индексов (строка, столбец) минимального элемента Матрицы
{
    int[] minIndex = new int[2];
    minIndex[0] = 0;
    minIndex[1] = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                minIndex[0] = i;
                minIndex[1] = j;
                min = matrix[i, j];
            }
        }
    }

    return minIndex;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("\n=>\n");

int[] array = FindIndexOfMinInMatrix(matrix);
PrintArray(array);

