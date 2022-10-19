//Эта прграмма выводит третью цифру заданного числа или сообщает, что такой цифры нет

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
            int result = (number % 10);
        Console.Write($"Третья цифра числа = {result}");
    }
}