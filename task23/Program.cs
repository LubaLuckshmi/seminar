// Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    TableCube(number);
}
else Console.WriteLine("Упс! Это не натуральное число!");

void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,6} {Math.Pow(count, 3), 6}");
        count++;
    }
}