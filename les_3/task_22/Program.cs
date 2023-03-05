Console.Write("введите число:");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++) {
    Console.WriteLine($"квадрат {i} = {i*i}");
}
