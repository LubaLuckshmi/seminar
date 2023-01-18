// Напишите программу, которая 
// 2 выводит третью цифру 2 заданного числа
//или сообщает, что третьей цифры нет
//  645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = ThirdDigit(number);
int result = num % 10;

Console.WriteLine(num >= 100 && num < 999 ?
 $"Третья цифра в числе {number} равна {result}" : "Третьей цифры нет");

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number;
}