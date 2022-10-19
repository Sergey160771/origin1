//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumAllCharsInNum(int num)
{
    if(num<= 0)
    {
    Console.WriteLine();
    return 0;
    }
    int lastchar =num %10;
    int sum = SumAllCharsInNum(num/10);
    return sum +lastchar;


}
System.Console.WriteLine(SumAllCharsInNum(12345));