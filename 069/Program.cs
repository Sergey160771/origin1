//Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

double Power(int num, int pow)
{
    if (pow == 0)
    {
        return 1;
    }
    return Power(num, pow - 1) * num;

}

Console.WriteLine(Power(2, 5));