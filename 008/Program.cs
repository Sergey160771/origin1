// Эта программа принимает на вход число, на выходе показывает все чётные числаот от 1 до N.
Console.WriteLine("Введите число");
string input = Console.ReadLine()!;  // ввод
int number = int.Parse(input)!;  // число

for (int i = 2; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}
