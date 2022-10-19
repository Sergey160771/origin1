//Эта программа находит точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void СalculatesPointIntersection()
{
    Console.Write("Введите коэффициент k1: ");
    double coefficient_K1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите коэффициент b1: ");
    double coefficient_B1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите коэффициент k2: ");
    double coefficient_K2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите коэффициент b2: ");
    double coefficient_B2 = double.Parse(Console.ReadLine()!);

    if (coefficient_K1 == coefficient_K2 && coefficient_B1 == coefficient_B2)
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coefficient_K1 == coefficient_K2)
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        double crossPoint_X = (coefficient_B2 - coefficient_B1) / (coefficient_K1 - coefficient_K2);
        double crossPoint_Y = coefficient_K2 * crossPoint_X + coefficient_B2;
        Console.Write($"\nТочка пересечения прямых: ({crossPoint_X:F3}, {crossPoint_Y:F3})");
    }
}
СalculatesPointIntersection();