//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int summ(int a)
    {
        int sum = 0;
        while (a !=0)
        {
            sum += a % 10;
            a /= 10;
        }
        return sum;
    }

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"сумма цифр {number} = {summ(number)}");
