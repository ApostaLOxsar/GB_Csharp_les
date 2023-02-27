// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int numbera = int.Parse(Console.ReadLine());
if (numbera % 2 == 0){
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет"); 
}