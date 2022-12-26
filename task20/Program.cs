// double d = Math.Sqrt(355); корень
// Math.Pow(2,2) квадрат
// double numD = 5.099873456;
// double numRound = Math.Round(numD, 2, MidpointRounding.ToZero); округление

// Напишите программу, которая 
// 1 принимает на вход координаты двух точек 
// 2 и находит расстояние между ними в 2D пространстве.
//  A (3,6); B (2,1) -> 5,09
//  A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты двух точек: ");
Console.Write("XА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YА: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, xb, ya, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между 2 точками с координатами {xa}, {xb} и {ya}, {yb} - > {ourDistance}.");

double Distance(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}
