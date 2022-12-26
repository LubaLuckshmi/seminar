// Напишите программу, которая
// 1 принимает на вход число n
// 2 и выдаёт таблицу квадратов чисел от 1 до n.
// 5 -> 1, 4, 9, 16, 25
// 2- > 1,4

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Упс! Это не натуральное число!");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t"+Math.Pow(count, 2));
        count++;
    }
}