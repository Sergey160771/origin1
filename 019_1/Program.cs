//Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом(Способ 2).

Console.WriteLine("Ведите пятизначное целое число");
int number = int.Parse(Console.ReadLine());

if (number % 10 == number / 10000  && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("Даное число является палиндромом");
}
else
{
    Console.WriteLine("Даное число не является палиндромом");
}