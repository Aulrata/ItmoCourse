const string path = "Numbers.txt";

if (!File.Exists(path))
    File.Create(path);

Random random = new();
using (StreamWriter sw = new(path, false))
{
    Console.WriteLine("Числа: ");
    for (int i = 0; i < 10; i++)
    {
        var number = random.Next(1, 10);
        sw.WriteLine(number);
        Console.Write($"{number} ");
    }
}


using StreamReader sr = new(path);

int sum = 0;
while (!sr.EndOfStream)
{
    sum += int.Parse(sr.ReadLine());
}

Console.WriteLine();
Console.WriteLine($"Сумма: {sum}");