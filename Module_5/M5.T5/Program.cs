Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

Console.WriteLine($"Сформированный массив {n}x{n}:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i + j) % 2 == 0)
            matrix[i, j] = 1;
        else
            matrix[i, j] = 0;
        
        Console.Write($"{matrix[i, j]} ");
    }

    Console.WriteLine();
}


