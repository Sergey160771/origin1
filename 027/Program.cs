//Эта программа  принимает на вход число и выдаёт сумму цифр в числе.

int SumThedigitsNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;
        sum = sum + digit;
    }
    return sum;
}
Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {number} = {SumThedigitsNumber(number)}");