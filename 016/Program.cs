// Эта прграмма принимает на вход два числа и проверяет, являются одно число квадратом другого

Console.WriteLine("Введите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторе число ");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.Write("Число является квадратом другого числа");
}
else
{
    Console.Write("Число не является квадратом другого числа");
}
