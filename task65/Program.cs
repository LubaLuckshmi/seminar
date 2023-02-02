// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
NaturalNumbersRange(firstNumber, secondNumber);

void NaturalNumbersRange(int num1, int num2)
{
    if (num1 == num2);
    
    else if (num1 < num2)
    {
        NaturalNumbersRange(num1, num2 - 1);
    }
    else if(num1 > num2)
    {
        NaturalNumbersRange(num1, num2+1);  
    }
   Console.Write($"{num2} ");
}