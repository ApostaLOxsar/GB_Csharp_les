//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("введите A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите B: ");
int b = int.Parse(Console.ReadLine());

int deg(int a, int b)
    {
        int c = Convert.ToInt32(Math.Pow(a, b));
        return c;
    }

Console.Write($"a ^ b = : {deg(a, b)}");
