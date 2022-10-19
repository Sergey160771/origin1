//Эта программ выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] CreateArray (int size) {
    int[] numBool = new int[size];
    for (int i = 0; i < size; i++)
    {
        numBool[i] = new Random().Next(0, 2);
    }
    return numBool;
}

void PrintArray (int[] array) {
    Console.WriteLine ($"[{string.Join (", ", array)}]");
}


PrintArray (CreateArray (8));
