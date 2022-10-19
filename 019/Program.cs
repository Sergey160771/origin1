//Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом(способ 1).

Console.WriteLine("Введите пятизначное число");
string DigitNumber = Console.ReadLine()!;

if (DigitNumber[0] == DigitNumber[4] && DigitNumber[1] == DigitNumber[3])
{
    Console.WriteLine("Данное число является палиндромом");
}    
else
{
    Console.WriteLine("Данное число не является палиндромом");
}    