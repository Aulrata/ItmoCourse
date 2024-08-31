
Console.WriteLine("Введите возрат в диапазоне 20-69 лет.");
int age = int.Parse(Console.ReadLine());

if (age is < 20 or > 69)
{
    Console.WriteLine("Вы ввели неверное значение");
    return;
}

int firstNumber = age / 10;
string ageInText = "";

ageInText += firstNumber switch
{
    2 => "Двадцать ",
    3 => "Тридцать ",
    4 => "Сорок ",
    5 => "Пятьдесят ",
    6 => "Шестьдесят ",
};

int secondNumber = age % 10;

switch (secondNumber)
{
    case 1:
        ageInText += "один ";
        break;
    case 2:
        ageInText += "два ";
        break;
    case 3:
        ageInText += "три ";
        break;
    case 4:
        ageInText += "четыре ";
        break;
    case 5:
        ageInText += "пять ";
        break;
    case 6:
        ageInText += "шесть ";
        break;
    case 7:
        ageInText += "семь ";
        break;
    case 8:
        ageInText += "восемь ";
        break;
    case 9:
        ageInText += "девять ";
        break;
        
}

ageInText += secondNumber switch
{
    1 => "год",
    2 or 3 or 4 => "года",
    _ => "лет",
};

Console.WriteLine(ageInText);