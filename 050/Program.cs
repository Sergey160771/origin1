// Эта программа  принимает на вход позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int height = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массва: ");
int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
LookingElementPosition(numbers);


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
void LookingElementPosition(int[,] numbers)
{
    Console.WriteLine("Введите номер строки : ");
    int numberline = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца: ");
    int numbercolumn = int.Parse(Console.ReadLine()!);

    if (numberline > numbers.GetLength(0) || numbercolumn > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет ");
    }
    else
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == numberline && j == numbercolumn)
                    Console.WriteLine($"Значение элемента {i} строки и {j} столбца равно {numbers[i, j]}");
            }
        }
    }
}
