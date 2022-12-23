// Напишите программу, которая
// на вход будет принимать 2 числа и 
// выводить, является ли первое число кратным второму
// Если число 1 не кратно числу 2, то программа выводит остаток от деления
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.WriteLine("Введите 2 числа: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int res = Multiplicity(firstNumber, secondNumber);
Console.WriteLine(res == 0 ? "Кратно" : $"Не кратно, остаток от деления {res}");

// bool result = firstNumber % secondNumber == 0;
// if (result) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток {firstNumber % secondNumber}");

int Multiplicity(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}
