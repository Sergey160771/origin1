//Эта программа принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ProductNumbers(int numbers)
{
    int product = 1;
    for (int i = 1; i <= numbers; i++)
    {
        product = product * i;
    }
       
 return product;
}
Console.Write("Введите N: ");
int numbers = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение чисел от 1 до {numbers} = {ProductNumbers(numbers)}");

