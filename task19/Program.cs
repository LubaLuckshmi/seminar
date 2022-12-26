// Напишите программу, которая 
// 1. принимает на вход пятизначное число
// 2. и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = (number / 10000) % 10;
int num2 = (number / 1000) % 10; 
int num4 = (number / 10) % 10;
int num5 = number % 10;

if (number >= 10000 && number < 99999)
{
    Console.WriteLine(Palindrom(num, num2, num4, num5) ? "Да" : "Нет");
}
else Console.WriteLine("Упс! Это не пятизначное число!");


bool Palindrom(int digit1, int digit2, int digit4, int digit5)
{
    return digit1 == digit5 && digit2 == digit4;
}
