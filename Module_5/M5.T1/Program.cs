int[] array = new int [7];
double avg = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    array[i] = int.Parse(Console.ReadLine());
    avg += array[i];
}

Console.WriteLine($"Среднее арифметическое: {avg / array.Length}");
