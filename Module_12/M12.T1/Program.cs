using M12.T1;

Console.Write("Введите радиус: ");
double radius = double.Parse(Console.ReadLine());

Console.Write("Введите X: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine($"Длина окружности: {Circle.GetLength(radius)}");
Console.WriteLine($"Площадь: {Circle.GetSquare(radius)}");
Console.WriteLine($"Точка ({x}, {y}){(Circle.IsInside(radius, x, y) ? string.Empty : " не")} входит в окружность с радиусом: {radius}.");