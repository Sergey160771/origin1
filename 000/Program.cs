// Эта программа  на вход  принимает число на выходе выдаёт квадрат этого числа.

Console.WriteLine("Введите число");

string input = Console.ReadLine()!;  // ввод

int number = int.Parse(input);  // число

int square = number * number;  // квадрат

Console.WriteLine($"Число в квадрате равно {square}");