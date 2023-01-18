// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfNumbers = NumberOfNumbers(number);
Console.WriteLine($"Количество цифр в числе {number} = {numberOfNumbers}");

int NumberOfNumbers(int digit)
{
    int count = 0;
    while(digit != 0)
    {
        digit = digit/10;
        count++;
    }
    return count;
}