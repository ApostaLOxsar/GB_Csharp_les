Console.WriteLine("введите целое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите квадрат первого числа: ");
int numberb = int.Parse(Console.ReadLine());
if (numberb == numberA * numberA) {
    Console.WriteLine("все верно");
}
else {
    Console.WriteLine("все плохо давай по новому");
}
