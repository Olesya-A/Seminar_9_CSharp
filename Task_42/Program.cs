// Задача 42 Перевести число из десятичной системы в двоичную (рекурсия)

Console.Write("Input integer number A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine(ConvertDecToBinaryRec(A));

string ConvertDecToBinaryRec(int A)
{
      if (A == 0)
      return string.Empty;

      return ($"{ConvertDecToBinaryRec(A / 2)}{A % 2}");
}
