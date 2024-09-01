//  Определить количество нечетных положительных элементов, стоящих на четных местах.
int[] array = new int[20];
Random random = new Random();
int count = 0;
Console.WriteLine("Исходный массив");

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-50, 51);
    Console.Write($"{array[i]} ");

    if (array[i] > 0 && array[i] % 2 == 1 && (i + 1) % 2 == 0)
        count++;
}

Console.WriteLine();
Console.WriteLine($"Кол-во: {count}");