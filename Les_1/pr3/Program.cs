Console.WriteLine("введите номер дня недели: ");
int numberA = int.Parse(Console.ReadLine());

switch (numberA)
{
    case 1:
        Console.WriteLine($"{numberA} это понедельник");
        break;
    case 2:
        Console.WriteLine($"{numberA} это вт");
        break;
    case 3:
        Console.WriteLine($"{numberA} это ср");
        break;
    case 4:
        Console.WriteLine($"{numberA} это чт");
        break;
    case 5:
        Console.WriteLine($"{numberA} это пт");
        break;
    case 6:
        Console.WriteLine($"{numberA} это суб");
        break;
    case 7:
        Console.WriteLine($"{numberA} это вск");
        break;
    default:
        Console.WriteLine($"{numberA} это не день недели");
        break;
}