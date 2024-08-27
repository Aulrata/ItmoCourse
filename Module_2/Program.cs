// See https://aka.ms/new-console-template for more information

#region Task_1

double length = 1.5;
double radius = length / 2 * Math.PI;
double square = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Радиус круга: {radius}, площадь круга: {square}");
#endregion

#region Task_2

double xA = 1, yA = 1, xB = 3, yB = 3;

double width = Math.Abs(xB - xA), height = Math.Abs(yB - yA);

double perimeter = (width + height) * 2;
square = width * height;

Console.WriteLine($"Периметр прямоугольника: {perimeter}, площадь прямоугольника: {square}");

#endregion

#region Task_3

xA = 1;
yA = 1;
xB = 3;
yB = 3;
double xC = 3, yC = 1;

double ab = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
double ac = Math.Sqrt(Math.Pow(xC-xA, 2) + Math.Pow(yC-yA, 2));
double bc = Math.Sqrt(Math.Pow(xC-xB, 2) + Math.Pow(yC-yB, 2));

perimeter = ab + ac + bc;
double semiPerimeter = perimeter / 2;

square = Math.Sqrt(semiPerimeter * (semiPerimeter - ab) * (semiPerimeter - ac) * (semiPerimeter - bc));

Console.WriteLine($"Длина сторон. AB: {ab}, AC: {ac}, BC: {bc}");
Console.WriteLine($"Периметр треугольника: {perimeter}, площадь треугольника: {square}");


#endregion