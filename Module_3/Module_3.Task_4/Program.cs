Console.WriteLine("Введите целое число в диапазоне 100-999");
int number = int.Parse(Console.ReadLine());

if (number is < 100 or > 999)
{
    Console.WriteLine("Вы ввели неверное число");
    return;
}

string result = "";

int firstNumber = number / 100;

result += firstNumber switch
{
    1 => "Сто ",
    2 => "Двести ",
    3 => "Триста ",
    4 => "Четыреста ",
    5 => "Пятьсот ",
    6 => "Шетьсот ",
    7 => "Семьсот ",
    8 => "Восемьсот ",
    9 => "Девятьсот ",
};

int secondNumber = number % 100 / 10;

result += secondNumber switch
{
    2 => "двадцать ",
    3 => "тридцать ",
    4 => "сорок ",
    5 => "пятьдесят ",
    6 => "шестьдесят ",
    7 => "семьдесят ",
    8 => "восемьдесят ",
    9 => "девяносто ",
    _ => ""
};

int specialNumber = number % 100;

if (specialNumber is < 20 and > 10)
{
    result += specialNumber switch
    {
        11 => "одиннадцать",
        12 => "двенадцать",
        13 => "тринадцать",
        14 => "четырнадцать",
        15 => "пятнадцать",
        16 => "шестнадцать",
        17 => "семнадцать",
        18 => "восемнадцать",
        19 => "девятнадцать",
    };
}
else
{
    int thirdNumber = number % 10;
    result += thirdNumber switch
    {
        1 => "один",
        2 => "два",
        3 => "три",
        4 => "четыре",
        5 => "пять",
        6 => "шесть",
        7 => "семь",
        8 => "восемь",
        9 => "девять",
        _ => ""
    };
}
Console.WriteLine(result);

