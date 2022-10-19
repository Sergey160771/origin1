//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int height = EnterInt("Ведите высоту массива: "); 
int width = EnterInt("Введите ширину массива: "); 
int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
FindsRowWithMinimumSumElements(numbers, height, width);

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

int FindsRowWithMinimumSumElements(int[,] numbers, int height, int width)
{
    int sum = 0;
    int minsum = 0;
    int minnum = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += numbers[i, j];
                minsum = numbers[i, j];
            }
            else sum += numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            minnum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"\nCтрока с наименьшей суммой элементов:{minnum} ");
    return minnum;
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