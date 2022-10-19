//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите число М:");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

void NumbersFromMToN(int numberM, int numberN)
{
    if (numberN < numberM)
        return;
    NumbersFromMToN(numberM, numberN - 1);
    Console.Write(numberN + " ");
}

NumbersFromMToN(numberM, numberN);