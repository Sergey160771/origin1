//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int height = EnterInt("Ведите высоту массива: "); // введите высоту 
int width = EnterInt("Введите ширину  массива: "); // Введите ширину


int[,] numbers1 = new int[height, width];
int[,] numbers2 = new int[height, width];
int[,] resultnumbers = new int[height, width];
Fill2DArray(numbers1);
Print2DArray(numbers1);
Fill2DArray(numbers2);
Console.WriteLine();
Print2DArray(numbers2);
MultiplyTwoMatrices(numbers1, numbers2, resultnumbers);
Console.WriteLine();
Print2DArray(resultnumbers);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers1.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 11);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++) 
    {
        for (int j = 0; j < numbers.GetLength(1); j++)  
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void MultiplyTwoMatrices(int[,] numbers1, int[,] numbers2, int[,] resultnumbers)
{
    if (numbers1.GetLength(0) != numbers2.GetLength(1))
    {
        Console.WriteLine("\n Нельзя перемножить ");
    }  
    else
    {
        for (int i = 0; i < numbers1.GetLength(0); i++)
        {
            for (int j = 0; j < numbers2.GetLength(1); j++)
            {
                resultnumbers[i, j] = 0;
                for (int k = 0; k < numbers1.GetLength(1); k++)
                {
                    resultnumbers[i, j] += numbers1[i, k] * numbers2[k, j];
                }
            }
        }
    }
}


