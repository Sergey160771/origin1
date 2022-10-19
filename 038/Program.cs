//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 2.5, 3.7, 1.9, 5.1, 6.7, 7.6, 28.0, 9.5, 10.7, 20.3 };

double CalculatesMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max) max = array[j];
        else if (array[j] < min) min = array[j];
        
    }
    result = max - min;
    return result;
}
void Printresult(double result)
{
    Console.Write($"Разница между максимальным и минимальным элементом равна {result}");
}
double result = CalculatesMinMax(array);
Printresult(result);