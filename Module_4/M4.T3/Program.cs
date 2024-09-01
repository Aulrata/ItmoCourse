Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int c = int.Parse(Console.ReadLine());

int area = 0;
int count = 0;
int areaOfSquare = 0;

while (count < a)
{
    area += b;
    count++;
}

count = 0;

while (count < c)
{
    areaOfSquare += c;
    count++;
}

count = 0;

while (areaOfSquare <= area)
{
    area -= areaOfSquare;
    count++;
}
Console.WriteLine($"В прямоугольник {a}x{b} поместилось {count} квадратов со стороной {c}");
