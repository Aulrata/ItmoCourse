
Console.WriteLine("Вводите последовательность чисел окончание последовательности = 0");
int number = 0, positiveNumbers = 0, negativeNumbers = 0;
do
{
    number = int.Parse(Console.ReadLine());

    switch (number)
    {
        case > 0:
            positiveNumbers++;
            break;
        case < 0:
            negativeNumbers++;
            break;
    }
    
} while (number != 0);

Console.WriteLine($"Кол-во положительный: {positiveNumbers}, кол-во отрицательных: {negativeNumbers}.");

if (positiveNumbers > negativeNumbers)
    Console.WriteLine("Положительных чисел больше.");
else if (positiveNumbers == negativeNumbers)
    Console.WriteLine("Положительных и отрицательных чисел равное количество.");
else
    Console.WriteLine("Отрицательных чисел больше.");
    