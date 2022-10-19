//Задайте двумерный массив.//Эта программа  заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int height = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массва: ");
int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Ordering(numbers);
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

void Ordering(int[,] numbers)
{
    if (numbers.GetLength(0) == numbers.GetLength(1))
    {
        int[,] array = new int[numbers.GetLength(0), numbers.GetLength(1)];
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                array[i, j] = numbers[i, j];
            }
        }

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = array[j, i];
            }
        }
    }
    else
    {
        Console.WriteLine($"Матрица не является квадратной ");  
    }
}