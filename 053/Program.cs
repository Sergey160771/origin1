// В этой программе пользователь задаёт двумерный  массив и меняет местами первую и последнюю строку
//В этой программе задаём двумерный массив из целых чисел и находим
//среднее арифметическое элементов в каждом столбце.
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
SwapFirstLastLine(numbers);
Print2DArray(numbers,height, width);

int height = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массва: ");

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

void SwapFirstLastLine(int[,] numbers)
{
    int temp =0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
         temp = numbers[0, i];
        numbers[0, i] = numbers[numbers.GetLength(1) - 1, i];
        numbers[numbers.GetLength(1) - 1, i] = temp;      
       
    }
Console.WriteLine();    
}
