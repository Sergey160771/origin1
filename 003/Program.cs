
Console.WriteLine("Введите число дня недели ");
int number = int.Parse(Console.ReadLine()!);
if (1 > number || number > 7)
{
    Console.WriteLine("Такого дня недели нет ");
}
if (number == 1)
{
    Console.WriteLine("Понедельник ");
}
if (number == 2)
{
    Console.WriteLine("Вторник ");
}
if (number == 3)
{
    Console.WriteLine("Среда ");
}
if (number == 4)
{
    Console.WriteLine("Четверг ");
}
if (number == 5)
{
    Console.WriteLine("Патница ");
}
if (number == 6)
{
    Console.WriteLine("Суббота ");
}
if (number == 7)
{
    Console.WriteLine("Воскресение ");
}