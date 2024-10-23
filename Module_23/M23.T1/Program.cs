Console.WriteLine("Введите число для факториала");
int number = int.Parse(Console.ReadLine());
var factorial = CountFactorial(number);
Console.WriteLine($"Main работает");


Console.WriteLine($"{number}! = {factorial.Result}");

async Task<long> CountFactorial(int number)
{
    if (number == 1)
        return number;

    return CountFactorial(number - 1).Result * number;
}