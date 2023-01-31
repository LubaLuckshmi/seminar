// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("  ]");
    }
}

// int[,] ChangeRowColumnsMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i, j] = matrix[j, i];
//         }
//     }
//     return newMatrix;
// }

void ChangeRowColumnsMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}

int matrixRows = 4;
int matrixColumns = 4;
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, 0, 9);

PrintMatrix(array2D);
if (matrixRows == matrixColumns)
{
    Console.WriteLine();
    // int[,] newMatrixChange = ChangeRowColumnsMatrix(array2D);
    // PrintMatrix(newMatrixChange);
    ChangeRowColumnsMatrix2(array2D);
    PrintMatrix(array2D);
}
else Console.WriteLine("Разное количество столбцов и строк. Невозможно поменять.");
