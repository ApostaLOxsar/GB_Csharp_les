// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numbera = int.Parse(Console.ReadLine()),
    numberb = int.Parse(Console.ReadLine());

if (numbera > numberb){
    Console.WriteLine($"max = {numbera}");
}
else {
    Console.WriteLine($"max = {numberb}");
}