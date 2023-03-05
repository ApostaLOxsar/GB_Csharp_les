//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void res(int a)
{
switch (a)
    {
    case 1:
        Console.Write("x > 0, y > 0");
        break;
    case 2:
        Console.Write("x > 0, y < 0");
        break;
    case 3:
        Console.Write("x < 0, y < 0");
        break;
    case 4:
        Console.Write("x < 0, y > 0");
        break;
    default:
        Console.Write("Входные с ошибкой");
        break;
    }
}

Console.Write("введите номер четверти:");
int a = int.Parse(Console.ReadLine());

res (a);
/*switch (a)
    {
    case 1:
        Console.Write("x > 0, y > 0");
        break;
    case 2:
        Console.Write("x > 0, y < 0");
        break;
    case 3:
        Console.Write("x < 0, y < 0");
        break;
    case 4:
        Console.Write("x < 0, y > 0");
        break;
    default:
        Console.Write("Входные с ошибкой");
        break;
    }
*/



