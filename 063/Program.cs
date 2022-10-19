//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowAllNums(int num)
{
    if (num < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{num} ");
    ShowAllNums(num - 1);
    Console.Write($"{num} ");

}
ShowAllNums(7);