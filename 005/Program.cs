//Эта  программа принимае на вход  одно число (N), а на выходе показывает все целые числа в промежутке от −N до N.

Console.WriteLine("Введите число");
string input = Console.ReadLine()!;  // ввод

int number = int.Parse(input);  // число

for (int i = -number; i < number + 1; i++)
    Console.Write($"{i} ");
