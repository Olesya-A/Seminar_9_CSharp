// 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);

Console.Write($"{numA} ^ {numB} = {Exponentation(numA, numB)}");

int Exponentation(int numA, int numB)
{
    if (numB == 0) return 1;
    return Exponentation(numA, numB - 1) * numA;
}