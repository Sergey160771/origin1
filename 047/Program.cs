//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


Console.Write("Введите высоту массива: ");
int height = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину массива : ");
int width = int.Parse(Console.ReadLine()!);

double[,] array = new double[height, width];

 void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }    
}
void PrintArray(double[,]array )
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,8:F3}", array[i, j]);

        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray(array);