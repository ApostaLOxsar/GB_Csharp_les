//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int getmultiplication(int number)
{
    int multipl = 1;
    for(int i = 1; i <= number; i++)
    {
        multipl *= i;
    }
    return multipl;
}


Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(getmultiplication(number));