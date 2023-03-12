//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Clear();

bool GetTriangle (int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (b + a)) 
    {
        return true;
    }
    else 
    {
        return false;
    }
}

Console.WriteLine("Введите сторону А");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону C");
int c = int.Parse(Console.ReadLine());

Console.Write(gettriangle(a, b, c));