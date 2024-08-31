Console.WriteLine("Введите длину окружности");
double length = double.Parse(Console.ReadLine());


double radius = length / 2 * Math.PI;
double square = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Радиус круга: {radius}, площадь круга: {square}");