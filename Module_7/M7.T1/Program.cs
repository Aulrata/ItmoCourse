// Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления
// площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона

Console.WriteLine("Введите стороны первого треугольника: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

Console.WriteLine("Введите стороны второго треугольника: ");
double a2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double c2 = double.Parse(Console.ReadLine());

double firstSquare = GetSquare(a, b, c);
double secondSquare = GetSquare(a, b, c);

Console.WriteLine($"Площадь {(firstSquare > secondSquare ? "первого" : "второго")} треугольника больше");

double GetSquare(double a, double b, double c)
{
    double semiPerimeter = (a + b + c) / 2;
    return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
}