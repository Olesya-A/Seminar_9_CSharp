// 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(NumeralRow(N));

string NumeralRow(int N)
{
    if (N == 1) return "1";
    else return NumeralRow(N - 1) +", "+ N;
}