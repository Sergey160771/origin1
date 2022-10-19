//В этой прогрмме пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray()
{
    Console.Write("введите количество элементов массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
int CountsPositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

void PrintCount(int count)
{
    Console.WriteLine($"Количество чисел больше 0 = {count} ");
}

int[] array = CreateArray();
int count = CountsPositiveElements(array);
PrintCount(count);