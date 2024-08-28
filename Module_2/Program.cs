// See https://aka.ms/new-console-template for more information

#region Task_1

Console.WriteLine("Введите длину окружности");
string? answer = Console.ReadLine();

double.TryParse(answer, out double length); 
double radius = length / 2 * Math.PI;
double square = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Радиус круга: {radius}, площадь круга: {square}");

#endregion

#region Task_2

Console.WriteLine("Введите координату x тчоки A прямоугольника");
double.TryParse(Console.ReadLine(), out double xA);

Console.WriteLine("Введите координату y тчоки A прямоугольника");
double.TryParse(Console.ReadLine(), out double yA);

Console.WriteLine("Введите координату x тчоки B прямоугольника");
double.TryParse(Console.ReadLine(), out double xB);

Console.WriteLine("Введите координату y тчоки B прямоугольника");
double.TryParse(Console.ReadLine(), out double yB);

double width = Math.Abs(xB - xA), height = Math.Abs(yB - yA);

double perimeter = (width + height) * 2;
square = width * height;

Console.WriteLine($"Периметр прямоугольника: {perimeter}, площадь прямоугольника: {square}");

#endregion

#region Task_3

Console.WriteLine("Введите координату x тчоки A треугольника");
double.TryParse(Console.ReadLine(), out xA);

Console.WriteLine("Введите координату y тчоки A треугольника");
double.TryParse(Console.ReadLine(), out yA);

Console.WriteLine("Введите координату x тчоки B треугольника");
double.TryParse(Console.ReadLine(), out xB);

Console.WriteLine("Введите координату y тчоки B треугольника");
double.TryParse(Console.ReadLine(), out yB);

Console.WriteLine("Введите координату x тчоки C треугольника");
double.TryParse(Console.ReadLine(), out double xC);

Console.WriteLine("Введите координату y тчоки C треугольника");
double.TryParse(Console.ReadLine(), out double yC);


double ab = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
double ac = Math.Sqrt(Math.Pow(xC-xA, 2) + Math.Pow(yC-yA, 2));
double bc = Math.Sqrt(Math.Pow(xC-xB, 2) + Math.Pow(yC-yB, 2));

perimeter = ab + ac + bc;
double semiPerimeter = perimeter / 2;

square = Math.Sqrt(semiPerimeter * (semiPerimeter - ab) * (semiPerimeter - ac) * (semiPerimeter - bc));

Console.WriteLine($"Длина сторон. AB: {ab}, AC: {ac}, BC: {bc}");
Console.WriteLine($"Периметр треугольника: {perimeter}, площадь треугольника: {square}");

#endregion