using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*// создаем новые потоки
Thread myThread1 = new Thread(new ParameterizedThreadStart(Print));
//Thread myThread2 = new Thread(Print);


// запускаем потоки
myThread1.Start(1233, 12);
//myThread2.Start("Привет");


void Print(object? message, object? message2)
{
    Console.WriteLine(message);
}

 
Person tom = new Person(22, 37);
// создаем новый поток
Thread myThread = new Thread(tom.Print);
myThread.Start();
 
record class Person(int Name, int Age)
{
    public void Print()
    {
        Console.WriteLine($"Name = {Name}");
        Console.WriteLine($"Age = {Age}");
    }
}*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = Factorial(n);
        Console.WriteLine($"Факториал {n} равен {result}");
        Console.ReadLine();
    }

    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

