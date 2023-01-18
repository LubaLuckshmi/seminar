// Напишите программу, которая 
// 1 на вход принимает 2 числа
// 2 и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет 

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int square = secondNumber * secondNumber;
if(firstNumber == square)
{
Console.WriteLine("Первое число является квадратом второго");
}
else 
{
Console.WriteLine("Первое число НЕ является квадратом второго");
}