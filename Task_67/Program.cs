// 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write(SumOfDigits(number));

int SumOfDigits(int number)
{
    if (number == 0) return 0;
    return SumOfDigits(number/10)+number%10;
}