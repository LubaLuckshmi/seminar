﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int[] MultiplyElemArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size +=1;
    int[] resArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        // resArr[i] = arr[i] * arr[(arr.Length - 1) - i];
        if (i != arr.Length -1 -i)
        resArr[i] = arr[i] * arr[arr.Length - 1 -i];
        else resArr[i] = arr[i];
    }
    return resArr;
}


int[] array = CreateArrayRndInt(10, 1, 5);
PrintArray(array);
int[] resArray = MultiplyElemArray(array);
PrintArray(resArray);