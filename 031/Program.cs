// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(- 10, 10);
    Console.Write(array[i] + " ");
    if(array[i] >= 0) sumPlus = array[i] + sumPlus;
    else sumMinus = array[i] + sumMinus;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumMinus}");
