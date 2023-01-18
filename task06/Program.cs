// Напишите программу, которая
// 1 на вход принимает число
// 2 и выдает, является ли число четным

Console.Write("Привет! Введи целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0) Console.WriteLine("Число четное?: да");
else Console.WriteLine("Число четное?: нет");