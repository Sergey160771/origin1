//Эта программа принимает на вход число и выдаёт количество цифр в числе.

int CountsNumberDigits(int number)
{
int count = 0;
while (number > 0)
{
    number = number / 10;   // оставить всё, кроме последней цифры
    count++;
}
return count;
}

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);   // 12345

Console.WriteLine($"Количество цифр в чиле {number} = {CountsNumberDigits(number)}");

