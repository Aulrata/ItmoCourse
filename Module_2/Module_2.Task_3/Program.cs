Console.WriteLine("Введите координату x тчоки A треугольника");
double xA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y тчоки A треугольника");
double yA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x тчоки B треугольника");
double xB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y тчоки B треугольника");
double yB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x тчоки C треугольника");
double xC = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y тчоки C треугольника");
double yC = double.Parse(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
double ac = Math.Sqrt(Math.Pow(xC-xA, 2) + Math.Pow(yC-yA, 2));
double bc = Math.Sqrt(Math.Pow(xC-xB, 2) + Math.Pow(yC-yB, 2));

double perimeter = ab + ac + bc;
double semiPerimeter = perimeter / 2;

double square = Math.Sqrt(semiPerimeter * (semiPerimeter - ab) * (semiPerimeter - ac) * (semiPerimeter - bc));

Console.WriteLine($"Длина сторон. AB: {ab}, AC: {ac}, BC: {bc}");
Console.WriteLine($"Периметр треугольника: {perimeter}, площадь треугольника: {square}");