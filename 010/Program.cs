// Э программа на вход принимает трёхзначное число и на выходе показывает
//  показывает вторую цифру этого числа

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = number / 10 % 10;
Console.Write($"Вторая цифра числа = {result}");
