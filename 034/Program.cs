//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


int evennumbers = 0;
const int size = 12;
int[] CreateRondomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int NumberEvenElements(int[] newarray)
{
    for (int i = 0; i < size; i++)
    {
        if (newarray[i] % 2 == 0) evennumbers++;
    }
    return evennumbers;
}
void Print(int evennumbers)
{
    Console.Write($"Количество чётных чисел в массиве:  {evennumbers}");
}

int[] newarray = CreateRondomArray(size);
NumberEvenElements(newarray);
Print(evennumbers);
