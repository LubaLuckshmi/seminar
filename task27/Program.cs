// Задача 27: Напишите программу, которая принимает 
// на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberOfNumbers = NumberOfNumbers(number);
int sumNumbers = SumNumbers(number, numberOfNumbers);

Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");

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

int SumNumbers(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}