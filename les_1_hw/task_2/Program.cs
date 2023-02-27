// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numbera = int.Parse(Console.ReadLine()),
    numberb = int.Parse(Console.ReadLine()),
    numberc = int.Parse(Console.ReadLine());
if (numbera >= numberb && numbera >= numberc) {
    Console.WriteLine($"max = {numbera}");
}
else if (numberb >= numbera && numberb >= numberc) {
    Console.WriteLine($"max = {numberb}");
}
    else {
    Console.WriteLine($"max = {numberc}");
}