// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = NaturalNumbersSum(firstNumber, secondNumber);
if (firstNumber >= 0 && secondNumber >= 0)
{
    Console.WriteLine("-> " + sum);
}
else Console.WriteLine("Вы ввели не натуральное число!");

int NaturalNumbersSum(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + NaturalNumbersSum(num1 + 1, num2);
    }
    if (num1 > num2)
    {
        return num1 + NaturalNumbersSum(num1 - 1, num2);
    }
    return num1;
}
