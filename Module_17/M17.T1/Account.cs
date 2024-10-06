namespace M17.T1;

public class Account<T>
{
    private T _number;
    private double _balance;
    private string? _firstName;
    private string? _lastName;
    private string? _middleName;

    public Account(T number, double balance, string? firstName, string? lastName, string? middleName)
    {
        _number = number;
        _balance = balance;
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
    }

    public void TopUp(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("You cannot have negative amount");
            return;
        }
        
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance || amount < 0)
        {
            Console.WriteLine("You cannot have more than balance or withdraw negative amount");
            return;
        }
        
        _balance -= amount;
    }
    
    public override string ToString() => $"Меня зовут {_lastName} {_firstName} {_middleName}. У меня на счету под " +
                                         $"номером {_number}, есть {_balance} рублей.";
    
}