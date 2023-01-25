// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
double resX = Math.Round(CoordinatesX(numberB1, numberK1, numberB2, numberK2), 1);
double resY = Math.Round(CoordinatesY(numberB1, numberK1, numberB2, numberK2), 1);
Console.WriteLine($"Пересечение в точке: ({resX}; {resY})");


double CoordinatesX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CoordinatesY(double b1, double k1, double b2, double k2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}

