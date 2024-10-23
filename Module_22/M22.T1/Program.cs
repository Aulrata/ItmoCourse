Console.WriteLine("Введите размер массива");
if (!int.TryParse(Console.ReadLine(), out var arraySize))
{
    Console.WriteLine("Вы ввели не число");
    return;
}

Random random = new();
var arrayOfNumbers = new int[arraySize];

arrayOfNumbers = arrayOfNumbers.Select(x => x = random.Next(10)).ToArray();

Console.WriteLine("Начальный массив");
foreach (var item in arrayOfNumbers)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Task sumTask = new(() => ArraySum(arrayOfNumbers));
var maxTask = sumTask.ContinueWith(x => ArrayMax(x, arrayOfNumbers));

sumTask.Start();
maxTask.Wait();

return;

void ArraySum(int[] array) => Console.WriteLine($"Сумма чисел массива: {array.Sum()}");
void ArrayMax(Task task, int[] array) => Console.WriteLine($"Максимальное число в массиве: {array.Max()}");