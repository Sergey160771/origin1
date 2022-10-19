////Эта  программа принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//(математический способ)
Console.WriteLine("Введите число");
string theeDigitnumber = Console.ReadLine()!;
int number = int.Parse(theeDigitnumber)!;
Console.WriteLine(number % 10);
