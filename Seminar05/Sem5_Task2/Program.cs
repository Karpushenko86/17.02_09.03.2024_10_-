// Задача 2.
// Задайте двумерный массив. Найдите сумму элементов, находящийся 
// на главной диагонали с индексами(0,0); (1;1) и т.д.
// Пример
// 2 3 4 3
// 4 3 4 1    =>    2 + 3 + 5 = 10
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)  //  Вместо 'rows' можно использоваться 'matrix.GetLength(0)'
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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int min = matrix.GetLength(0);
    if (matrix.GetLength(1) < min) min = matrix.GetLength(1);

    for (int i = 0; i < min; i++)
    {
        sum += matrix[i, i];
    }

    return sum;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
int sum = SumMainDiagonal(matrix);
Console.WriteLine($"\n{sum,4}");