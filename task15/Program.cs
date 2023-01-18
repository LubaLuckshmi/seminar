// Напишите программу, которая 
// 1 принимает на вход цифру, обозначающую день недели, 
// 2 и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи номер дня недели от 1 до 7, а программа проверит выходной ли это день: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 6 && number <= 7) Console.WriteLine("Да");
else if (number >= 1 && number <= 5) Console.WriteLine("Нет");
else Console.WriteLine("Ошибка: В неделе всего 7 дней!");