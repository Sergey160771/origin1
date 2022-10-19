//Эта программа принимает на вход два числа и выводит является  ли второе число 
// кратным первому.Если втрое число не кратно первому, то выводит остаток от деления.

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе  число");
int numberB = int.Parse(Console.ReadLine());

int remainder = numberA % numberB;

if (remainder == 0)
{
    Console.WriteLine($"Первое числа {numberA} кратно второму числу {numberB}");
}
else
{
    Console.WriteLine($"Числа не кратны друг другу, остаток от деления = {remainder}");
}
