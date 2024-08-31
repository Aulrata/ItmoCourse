Console.WriteLine("Введите первую координату");
Console.Write("x: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую координату");
Console.Write("x: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третью координату");
Console.Write("x: ");
int x3 = int.Parse(Console.ReadLine());
Console.Write("y: ");
int y3 = int.Parse(Console.ReadLine());

if ((x1 == x2 || x1 == x3 || x2 == x3) && (y1 == y2 || y1 == y3 || y2 == y3))
{
    int x4;
    if (x1 == x2) 
        x4 = x3;
    else
        x4 = x1 == x3 ? x2 : x1;

    int y4;
    if (y1 == y2) 
        y4 = y3;
    else
        y4 = y1 == y3 ? y2 : y1;

    Console.WriteLine($"Координаты четвертой точки. x: {x4}, y: {y4}");
}
else
{
    Console.WriteLine("Вы ввели неверные координаты");
}

// (1,1) 
// (3,3)  
// (3,1) 