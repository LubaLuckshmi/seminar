// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число и программа преобразует его в двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertDecToBin(number));

string ConvertDecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}


// Второй способ через ИНТ

// int ConvertDeToBin(int num)
// {
//     int result = 0;
//     int multiplyer = 1;

//     while (num != 0)
//     {
//         result = result + num % 2 * multiplyer;
//         num = num / 2;
//         multiplyer *= 10;
//     }
//     return result;
// }