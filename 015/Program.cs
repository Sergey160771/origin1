// Эта программа принимает число дня недели и на выходе выдаёт является, 
// этот день выходным. 

Console.WriteLine("Введите число дня недели");
int DayWeek = int.Parse(Console.ReadLine());

if (DayWeek < 1 || DayWeek > 7)
{ 
   Console.WriteLine("Не коректный день недели");
}   
else  
 if (DayWeek == 6 || DayWeek == 7)
 {
Console.WriteLine("Выходной");
}
 else
{
Console.WriteLine("Будни");
}



