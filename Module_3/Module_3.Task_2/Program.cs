Console.WriteLine("Введите координаты точек");
Console.Write("A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("B: ");
int b = int.Parse(Console.ReadLine());

Console.Write("C: ");
int c = int.Parse(Console.ReadLine());

int ab = Math.Abs(a - b);
int ac = Math.Abs(a - c);


if (a == b && a == c)
    Console.WriteLine("Точки A, B и C находятся на одной координате.");
else if (b == c)
    Console.WriteLine("Точки C и B совпадают.");
else if (ab == ac) 
    Console.WriteLine("Точки B и C равноудалены от точик A.");
else
    Console.WriteLine($"Точка {(ab > ac ? "C" : "B")} ближе всего расположенна к точке A.");
