// Напишите программу, которая 
// 1. на вход принимает число
// 2. выдает его квадрат (число, умноженное само на себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Привет! Введи целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа: {number} = {square}");