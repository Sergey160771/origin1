//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число М:");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

int SumFromMToN(int numberM, int numberN)
{
    if (numberN == numberM) return numberN;
    return numberM + SumFromMToN(numberM + 1, numberN);
}
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {SumFromMToN(numberM, numberN)}");