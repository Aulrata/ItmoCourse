// Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, 
// вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. Магическим 
// квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int [,] arr = new int[n, n];


Console.WriteLine($"Введите числа для матрицы {n}x{n}");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ваш квадрат");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write($"{arr[i, j]} ");
    Console.WriteLine();
}

int sumColumn = 0, sumRow = 0, sumDiagonal = 0, sumSecondaryDiagonal = 0;
bool isMagicSquare = true;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sumColumn += arr[j, i];
        sumRow += arr[i, j];

        if (i + j + 1== n)
        {
            sumSecondaryDiagonal += arr[i, j];
        }
    }

    sumDiagonal += arr[i, i];
    if (sumColumn != sumRow)
    {
        isMagicSquare = false;
        break;
    }
}

Console.WriteLine();
if (sumDiagonal == sumSecondaryDiagonal && isMagicSquare)
    Console.WriteLine("Квадрат является магическим");
else 
    Console.WriteLine("Квадрат не является магическим");

