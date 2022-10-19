//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

Console.Write("Введите длины сторон треугольника чез пробел:");
string sides = Console.ReadLine()!;
string[] parts = sides.Split(' ');
int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int c = int.Parse(parts[2]);

bool IsTriangleExist(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

if (IsTriangleExist(a, b, c))
{
    Console.WriteLine("Треулольник существует");
}
else Console.WriteLine(" Треулольник не существует");
