//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 0)
    {
    number *= -1;
    }

if (number < 100)
    {
    Console.Write("Введенное число меньше трехзначного (3ей цифры нет)");
    }
else if (number > 999)
        {
        while (number > 999) 
            {
            number /= 10;
            }
        int number_3 = number % 10;
        Console.WriteLine($"Искомое число {number_3}");
        }
        else if (number > 99 && number < 1000)
            {
            int number_3 = number % 10;
            Console.WriteLine($"Искомое число {number_3}");
            }
            else
            {
            Console.WriteLine("Введенные данные не коректны");   
            }
    