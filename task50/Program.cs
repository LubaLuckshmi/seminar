// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  ]");
    }
}

bool IsExistIndex(int[,] numbers, int i, int j)
{
    return i < numbers.GetLength(0) && j < numbers.GetLength(1);
}

Console.WriteLine("Угадайте, присутствует ли элемент в массиве по его позиции! Введите индекс строки (счет с нуля):");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца (счет с нуля): ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
Console.WriteLine();
PrintMatrix(array2D);
if (rows >= 0 && columns >= 0)
{
    bool result = IsExistIndex(array2D, rows, columns);
    Console.WriteLine(result ? "Такой элемент есть: " + array2D[rows, columns]
    : $"{rows},{columns} -> такого элемента в массиве нет");
}
else
{
    Console.WriteLine("Вы ввели неверное значение");
}
