//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);

PrintArrey(GetFibonacci(n));

int[] GetFibonacci(int n)
{
    int[] fibo = new int[n];
    fibo[0] = 0;
    fibo[1] = 1;

    for (int i = 2; i < n; i++)
    {
        fibo[i] = fibo[i - 2] + fibo[i - 1];
    }
    return fibo;
}

void PrintArrey(int[] fibs)
{

    foreach (int fib in fibs)
    {
        Console.Write($"{fib} ");
    }
    Console.WriteLine();

}