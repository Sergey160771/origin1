// Эта  программу  по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
Console.WriteLine(" X > 0 and Y > 0");
else if (quarter == 2)
Console.WriteLine(" X < 0 and Y > 0");
else if (quarter == 3)
Console.WriteLine(" X < 0 and Y < 0");
else if (quarter == 4)
Console.WriteLine(" X > 0 and Y < 0");
else
Console.WriteLine("такой четверти не существует");

