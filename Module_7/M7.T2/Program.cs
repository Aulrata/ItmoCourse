// Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
Console.WriteLine("Введите длину ребра куба: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine($"Объем куба: {GetVolume(length)}, площадь поверхности куба: {GetSquare(length)}");

double GetVolume(double length)     // Проще было бы с лямдой выражения) double GetVolume(double length) => Math.Pow(length, 3);
{
    return Math.Pow(length, 3);
}

double GetSquare(double length)     // double GetSquare(double length) => Math.Pow(length, 2);
{
    return Math.Pow(length, 2);
}



