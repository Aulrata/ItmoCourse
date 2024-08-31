
Console.WriteLine("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine());
int square = 0;

for (int i = 1; i < n + 1; i++)
{
    square += 2 * i - 1;
}

Console.WriteLine($"Ваше число {n} в квадрате равно {square}");