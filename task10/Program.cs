// Напишите программу, которая
// 1 принимает на вход трехзначное число
// 2 и на выходе показывает вторую цифру этого числа
//  456 -> 5, 785 -> 8, 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
//     Console.Write($"Вторая цифра в числе {number} равна {(number / 10) % 10}");
// else
//     Console.Write("Вы ввели не трехзначное число");

int res = Remains(number);
Console.WriteLine(number >= 100 && number <= 999 ? 
$"Вторая цифра в числе {number} равна {res}" : "Вы ввели не трехзначное число");

int Remains(int num)
{
    return (num / 10) % 10;
}