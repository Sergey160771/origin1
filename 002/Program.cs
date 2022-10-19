// Эта программа принимает на вход два числа и выдаёт какое число больше

Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine())!; 
Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine())!; 
int max = numberA;
if (max < numberB) max = numberB;
{
    Console.WriteLine($"max= {max}");
}
