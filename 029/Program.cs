// В этой программе пользователь вводит 8 чисел .Необходимо поместите их в массив и распечатайте.

int[] InputArrayElements()
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
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");

}
int[] array = InputArrayElements();
PrintArray(array);
