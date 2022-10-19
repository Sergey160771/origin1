// Эта программа выводит случайное число и удоляет вторую цифру этого числа

int number = new Random().Next(10, 1000);   // number = число
Console.WriteLine(number);

Console.Write($"{number / 100}{number % 10}");