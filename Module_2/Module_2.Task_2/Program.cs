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
double square = width * height;

Console.WriteLine($"Периметр прямоугольника: {perimeter}, площадь прямоугольника: {square}");