
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

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;

    }
}

void ReverseArrayVersion2(int[] arr)
{
    int index1 = 0;
    int index2 = arr.Length - 1;

    while (index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRndInt(10, 1, 5);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
Array.Reverse(array);
PrintArray(array);
ReverseArrayVersion2(array);
PrintArray(array);