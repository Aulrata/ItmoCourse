var myDelegate = new MyDelegate(CircleLength);
myDelegate += CircleSquare;
myDelegate += CircleVolume;

Console.Write("Введите радиус: ");
var radius = int.Parse(Console.ReadLine());
myDelegate(radius);

static double CircleLength(double r)
{
    var length = 2 * Math.PI * r;
    Console.WriteLine($"Длина окружности: {length}");
    return length;
}

static double CircleSquare(double r)
{
    var square = Math.PI * Math.Pow(r, 2);
    Console.WriteLine($"Площадь окружности: {square}");
    return square;
};

static double CircleVolume(double r)
{
    var volume = 4.0 / 3  *Math.PI * Math.Pow(r, 3);
    Console.WriteLine($"Объем окружности: {volume}");
    return volume;
};

delegate double MyDelegate(double number);