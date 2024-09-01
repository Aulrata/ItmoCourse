int[] array = new int[15];
Random random = new Random();

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 51);
    if (array[i] > max)
        max = array[i];
    
    if (array[i] < min)
        min = array[i];
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Max: {max}, Min: {min}. Sum: {max + min}");

