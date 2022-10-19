//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int height = EnterInt("Ведите высоту массива: ");  
int width = EnterInt("Введите ширину  массива: "); 
int @long = EnterInt("Введите длинну  массива: "); 

int[,,] numbers = new int[height, width, @long];

 Fill2DArray(numbers);
 Console.WriteLine();
 Print2DArray(numbers);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


void Fill2DArray(int[,,]numbers )
{
  int[] temp = new int[numbers.GetLength(0) * numbers.GetLength(1) * numbers.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        if (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      for (int k = 0; k < numbers.GetLength(2); k++)
      {
        numbers[i, j, k] = temp[count];
        count++;
      }
    }
  }
}


void Print2DArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write($"{numbers[i, j, k]}({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
