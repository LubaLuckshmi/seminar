// Напишите программу, которая 
// 1 принимает на вход координаты двух точек
// 2 и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек: ");
Console.Write("XА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YА: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());


double ourDistance = Math.Round(Distance(xa, xb, ya, yb, za, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между 2 точками с координатами {xa}, {ya}, {za} и {xb}, {yb}, {zb} - > {ourDistance}.");

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2-z1), 2));
    return distance;
}
