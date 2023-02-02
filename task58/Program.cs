// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] MyltiplyMatrix(int[,] matrix1, int[,] matrix2)
{
        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return resultMatrix;
}

int matrixRows1 = 1;
int matrixColumns1 = 2;
int matrixRows2 = 9;
int matrixColumns2 = 1;

int[,] array2Dfirst = CreateMatrixRndInt(matrixRows1, matrixColumns1, 0, 9);
int[,] array2Dsecond = CreateMatrixRndInt(matrixRows2, matrixColumns2, 0, 9);


PrintMatrix(array2Dfirst);
Console.WriteLine();
PrintMatrix(array2Dsecond);
Console.WriteLine();

 if (matrixColumns1 != matrixRows2) Console.WriteLine("Умножение матриц невозможно");
    else
    {
int[,] myltiplyMatrix = MyltiplyMatrix(array2Dfirst, array2Dsecond);
PrintMatrix(myltiplyMatrix);
    }