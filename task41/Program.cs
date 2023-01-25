// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество числе M, которое собираетесь ввести, а программа посчитает, сколько из них больше 0: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите числа (через Enter): ");
int[] array = CreateArray(numberM);
PrintArray(array);

int countElements = CountElements(array);
Console.WriteLine(" -> " + countElements);


int[] CreateArray(int num)
{
    int[] result = new int [num];
    
    for (int i = 0; i < num; i++)
    {
        result [i] = int.Parse(Console.ReadLine());
    }
  
    return result;
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

int CountElements(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >0) count ++;
    }
    return count;
}