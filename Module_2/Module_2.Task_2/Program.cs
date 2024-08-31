Console.WriteLine("Введите координату x тчоки A прямоугольника");
double xA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y тчоки A прямоугольника");
double yA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x тчоки B прямоугольника");
double xB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y тчоки B прямоугольника");
double yB = double.Parse(Console.ReadLine());

double width = Math.Abs(xB - xA), height = Math.Abs(yB - yA);

double perimeter = (width + height) * 2;
double square = width * height;

Console.WriteLine($"Периметр прямоугольника: {perimeter}, площадь прямоугольника: {square}");