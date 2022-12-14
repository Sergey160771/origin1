//Эта программа принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X точки А:");
int xA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки А:");
int yA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки А:");
int zA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B:");
int xB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки B:");
int yB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки B:");
int zB = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Растояние между этими двумя точками равно {distance:F2}");
