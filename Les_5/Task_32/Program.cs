//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] array = new int[8];

void fillarray (int collect)
{
    for(int i = 0; i < 8; i++)
    {
        array[i]= new Random().Next(-20,21);
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void reversarray (int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        array[i] *= -1;
    }
}

void output(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

fillarray (8);
reversarray(array);
output(array);
