// Напишите программу, которая
// 1. принимает на вход число 
// 2 и проверяет кратно ли оно одновремено 7 и 23.
// 14 -> Нет
// 161 -> Да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BothMultiple(number) ? "Да" : "Нет");

bool BothMultiple(int num, int num1 = 7, int num2 = 23)
{
    return num % num1 == 0 && num % num2 == 0;
}