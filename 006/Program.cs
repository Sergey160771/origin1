// Эта прграмма принимает на вход чило, а на выходе выдаёт чётное оно или не чётное
//С исправлениями замечаний

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.Write("Введенное число четое");
}
else
{
    Console.Write("Введенное число не чётное");
}

