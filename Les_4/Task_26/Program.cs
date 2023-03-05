//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int getnumber (int number)
    {
        int quantity = 0;
        while (number !=0)
        {
            number /= 10;
            quantity++;
        }

        return(quantity);
    }

Console.Write("введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(getnumber(number));