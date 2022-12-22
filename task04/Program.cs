// Напишите программу, которая
// 1 принимает на вход 3 числа
// 2 и выдает максимальное из этих чисел

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;
Console.Write("max = ");
Console.Write(max);