// Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
Console.WriteLine("Введите длину ребра куба: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine($"Объем куба: {GetMultiplication(length, "volume")}, площадь поверхности куба: {GetMultiplication(length, "square")}");

double GetMultiplication(double length, string type)
{
    return type switch
    {
        "volume" => Math.Pow(length, 3),
        "square" => Math.Pow(length, 2),
        _ => 0
    };
}



