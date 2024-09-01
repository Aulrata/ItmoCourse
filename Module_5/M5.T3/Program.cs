int[] array = new int[10];
Random random = new Random();

Console.WriteLine("Исходный массив");

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-50, 51);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length / 2 - 1; i++)
{
    for (int j = i + 1; j < array.Length / 2; j++)
    {
        if (array[j] < array[i])
            (array[i], array[j]) = (array[j], array[i]);
    }
}

for (int i = array.Length / 2; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[i])
            (array[i], array[j]) = (array[j], array[i]);
    }
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив");
foreach (var item in array)
{
    Console.Write($"{item} ");
}