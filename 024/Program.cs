// Эта програмапринимает на вход число, а на выходе выдаёт сумму чисед от одного до N 

Console.Write ("Введите N: ");
int max = int.Parse (Console.ReadLine ()!);

int sum = 0;
for (int i = 1; i <= max; i++)   // 1 2 3 4 5
    sum = sum + i;
Console.WriteLine ($"Сумма чисел от 1 до N = {sum}");
