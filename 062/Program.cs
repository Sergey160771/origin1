//Заполните спирально массив 4 на 4.


int n = 4;
int[,] numburs = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= numburs.GetLength(0) * numburs.GetLength(1))
{
    numburs[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < numburs.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= numburs.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > numburs.GetLength(1) - 1)
        j--;
    else
        i--;
}


void FillsSpiralArray(int[,] numburs)
{
    for (int i = 0; i < numburs.GetLength(0); i++)
    {
        for (int j = 0; j < numburs.GetLength(1); j++)
        {
            if (numburs[i, j] / 10 <= 0)
                Console.Write($" {numburs[i, j]} ");

            else Console.Write($"{numburs[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillsSpiralArray(numburs);