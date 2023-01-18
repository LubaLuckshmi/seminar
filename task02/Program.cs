/* Напишите программу, которая 
1 на вход принимает 2 числа
2 и выдает, какое число большее, а какое меньшее */

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if(secondNumber > max) 
{
Console.WriteLine($"Max = {secondNumber}");
}
else 
{
Console.WriteLine($"Max = {firstNumber}");
}