//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());

switch (number)
    {
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресеьнья");
        break;
    default:
        Console.WriteLine("Введенные данные некоректны либо нет такого дня недели");
        break;
    }