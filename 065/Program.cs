//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
void ShowNumsBetween(int min, int max)
{
    if (min == max)
    {
        Console.Write(min);
        return;
    }
    if (min > max)
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min - 1, max);
    }
    else
    {
        Console.Write($"{max} ");
        ShowNumsBetween(min, max - 1);

    }
}
ShowNumsBetween(3, 9);
