//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int height = EnterInt("Ведите высоту массива: ");  
int width = EnterInt("Введите ширину массива: "); 

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
SortsRowsDescending(numbers, height, width);
Console.WriteLine();
Print2DArray(numbers, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}
void SortsRowsDescending(int[,] numbers, int height, int width)
        {
    int temp = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  
      {
        for (int j = 0; j < width; j++)      
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}
