// Напишите программу, которая 
// 2 выводит третью цифру 2 заданного числа
//или сообщает, что третьей цифры нет
//  645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = number %10;

Console.WriteLine(number >= 100 ?
 $"Третья цифра в числе {number} равна {thirdDigit}" : "Третьей цифры нет");
