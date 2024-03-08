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
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1);

    int[,] localMatrix = new int[rows, columns];        // Выделяем память под матрицу с учетом удаления строки 

    int k = 0;
    for (int i = 0; i < rows + 1; i++)
    {
        if (i == rows && i == minIndex[0])              // Если строка последний
        {
            break;
        }

        if (i == 0 && i == minIndex[0])                 // Если строка вначале
        {
            i++;
            k++;
        }

        if (i > 0 && i < rows && i == minIndex[0])      // Если строка посередине
        {
            i++;
            k++;
        }       

        for (int j = 0; j < columns; j++)               // Запись по элементам столбца (Важно!!!)
        {
            localMatrix[i - k, j] = matrix[i, j];
        }
    }

    return localMatrix;
}

int[,] DeleteColumnInMatrix(int[,] matrix, int[] minIndex)   // Возвращает Матрицу без колонны
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1) - 1;

    int[,] localMatrix = new int[rows, columns];        // Выделяем память под матрицу с учетом удаления столбца 

    int k = 0;
    for (int j = 0; j < columns + 1; j++)
    {     
        if (j == columns && j == minIndex[1])           // Если столбец последний
        {
            break;
        }

        if (j == 0 && j == minIndex[1])                 // Если столбец вначале
        {
            j++;
            k++;
        }

        if (j > 0 && j < columns && j == minIndex[1])   // Если столбец посередине
        {
            j++;
            k++;
        }       

        for (int i = 0; i < rows; i++)                  // Запись по элементам строки (Важно!!!)
        {
            localMatrix[i, j - k] = matrix[i, j];
        }
    }

    return localMatrix;
}

int[] FindIndexOfMinInMatrix(int[,] matrix)             // Возвращает Массив индексов (строка, столбец) минимального элемента Матрицы
{
    int[] minIndex = new int[2];
    minIndex[0] = 0;    // Ячейка массива для хранения индекса строки
    minIndex[1] = 0;    // Ячейка массива для хранения индекса столбца
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
    Console.Write($"{array[array.Length - 1]}]\n");
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("\n=>\n");

int[] array = FindIndexOfMinInMatrix(matrix);
PrintArray(array);

Console.WriteLine("\n=>\n");

matrix = DeleteRowInMatrix(matrix, array);
// PrintMatrix(matrix);

// Console.WriteLine("\n=>\n");

matrix = DeleteColumnInMatrix(matrix, array);
PrintMatrix(matrix);
