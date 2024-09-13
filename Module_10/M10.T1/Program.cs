using M10.T1;

Console.WriteLine("Введите градусы: ");
double degree = double.Parse(Console.ReadLine());

Console.WriteLine("Введите минуты: ");
int minutes = int.Parse(Console.ReadLine());

Console.WriteLine("Введите секунды: ");
int seconds = int.Parse(Console.ReadLine());


Angle angle = new(degree, minutes, seconds);
Console.WriteLine($"Градусы: {angle.Degree}, минуты: {angle.Minutes}, секунды: {angle.Seconds}");
Console.WriteLine($"Радианы: {angle.ToRadians()}");