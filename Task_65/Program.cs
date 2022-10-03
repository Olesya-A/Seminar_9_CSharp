// 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5 -> "5, 4, 3, 2, 1"
// M = 4; N = 8 -> "8, 7, 6, 5, 4"

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(NumeralRow(M, N));

string NumeralRow(int M, int N)
{
    if (N == M) return $"{M}";
    else return N + ", " + NumeralRow(M, N - 1);
}