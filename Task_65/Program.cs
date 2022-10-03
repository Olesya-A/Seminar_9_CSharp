// 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5 -> "5, 4, 3, 2, 1"
// M = 4; N = 8 -> "8, 7, 6, 5, 4"

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int min = M;
int max = N;
if (N < M)
{
    min = N;
    max = M;
}

Console.Write(NumeralRow(min, max));

string NumeralRow(int min, int max)
{
    if (max == min) return $"{min}";
    else return max + ", " + NumeralRow(min, max - 1);
}



// int rangeMin = Min(M, N);
// int rangeMax = Max(M, N);

// int Min(int a, int b)
// {
//       return a < b ? a : b; 
// }

// int Max(int a, int b)
// {
//       return a > b ? a : b; 
// }