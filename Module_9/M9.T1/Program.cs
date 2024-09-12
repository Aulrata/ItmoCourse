
bool exit = false;

while (!exit)
{
    try
    {
        Console.Write("Введите первое число: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(
            "Выберите один из пунктов меню: \n1)Сложение \n2)Вычитание \n3)Умножение \n4)Деление \n5)Выход");
        string ans = Console.ReadLine();

        double result = 0;

        switch (ans)
        {
            case "1":
                result = firstNumber + secondNumber;
                break;
            case "2":
                result = firstNumber - secondNumber;
                break;
            case "3":
                result = firstNumber * secondNumber;
                break;
            case "4":
                result = firstNumber / secondNumber;
                break;
            case "5":
                exit = true;
                break;
            default:
                throw new MenuException();

        }

        Console.WriteLine($"Результат: {result}");

    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (MenuException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
    }

}


public class MenuException : Exception
{
    public override string Message { get; } = "Вы выбрали неверный пункт меню";
}



