


Console.Clear();
int[,] array = new int[7, 9];

void fillArray (int column, int line)
{ 
    for(int i = 0; i < column; i++)
    {
        for(int j = 0; j < line; j++)
        {
            array[i, j]= new Random().Next(0,10);
            Console.Write($"{array[i, j]} ");  //вывод массива
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}


void outArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");  //вывод массива
        }
        Console.WriteLine("");
    }
}

fillArray(array.GetLength(0), array.GetLength(1));
outArray(array);
