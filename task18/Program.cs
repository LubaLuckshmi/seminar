// Напишите программу, которая 
// 1 по заданному номеру четверти, 
// 2 показывает диапазон  координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string result = Coord(quarter);
Console.WriteLine(result);

string Coord(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0 , y > 0";
    if (num == "3") return "x < 0 , y < 0";
    if (num == "4") return "x > 0 , y < 0";
    return "Увы! Такой четверти нет!";
}