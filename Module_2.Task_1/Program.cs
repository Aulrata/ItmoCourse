Console.WriteLine("Введите длину окружности");
string? answer = Console.ReadLine();

double.TryParse(answer, out double length); 

double radius = length / 2 * Math.PI;
double square = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Радиус круга: {radius}, площадь круга: {square}");