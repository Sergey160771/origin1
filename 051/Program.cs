//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int height = EnterInt("Enter height: "); // введите высоту 
int width = EnterInt("Enter width: "); // Введите ширину

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
CalculatesSumElementsMainDiagonal(numbers, height, width);



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
int CalculatesSumElementsMainDiagonal(int[,] numbers, int height, int width)
{
    int sum = 0;

    for (int i = 0; i < height && i < width; i++)
    {
        sum += numbers[i, i];

    }
    Console.WriteLine($"\nСумма элементов главной диагонали = {sum}");

    return sum;
}


void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)  // для каждой строки
    {
        for (int j = 0; j < width; j++)  // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}
