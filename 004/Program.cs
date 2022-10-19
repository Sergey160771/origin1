// Эта программа принимает на вход три числа и выдаёт какое число больше

Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите третье число ");
int numberC = int.Parse(Console.ReadLine()!); 
int max = numberA;

if (numberB > max) max = numberB;
{
    if (numberC > max) max = numberC;
}
Console.WriteLine($"max= {max}");

