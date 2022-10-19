//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

const int size = 12;
int sum = 0;

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
for (int i = 1; i < size; i = i + 2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма нечётных элементов массива = {sum}");




