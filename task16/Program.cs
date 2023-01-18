// Напишите программу, которая
// 1 принимает на входе 2 числа,
// 2 и проверяет, является ли одно число квадратом другого


Console.WriteLine("Введите 2 числа: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareNumber(firstNumber, secondNumber) ? "Да" : "Нет");

bool SquareNumber(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
