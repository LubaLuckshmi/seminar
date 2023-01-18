// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите 2 числа А и В, где В - натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

int degreeOfNumber = DegreeOfNumber(numA, numB);

if (numB > 0)
{
    Console.WriteLine($"Число {numA} в степени {numB} = {degreeOfNumber}");
}
else Console.WriteLine("Упс! Число В не натуральное!");

int DegreeOfNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        checked
        {
            result = result * a;
        }

    }
    return result;
}