using M11.T1;

Console.WriteLine("Введите k: ");
double k = double.Parse(Console.ReadLine());

Console.WriteLine("Введите b: ");
double b = double.Parse(Console.ReadLine());


LinearEquation linearEquation = new(k, b);
Console.WriteLine($"Корень: {linearEquation.Root()}");