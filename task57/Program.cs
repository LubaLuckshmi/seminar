// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

void Dictionary(int[] array)
{
    int number = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number} -> {count}");
}

// int[,] UniqElem(int[] arr)
// {
//     int count = 0;
//     int[,] arr2D = new int[arr.GetLength(0),1];

//     int currentElem = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == arr[i+1]) count++;
//         else
//         {
//             arr2D[,]
//         }
//     }
// }

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);

PrintMatrix(array2D);
Console.WriteLine();
int[] array = MatrixToArray(array2D);
PrintArray(array);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
Dictionary(array);