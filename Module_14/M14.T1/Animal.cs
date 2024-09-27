namespace M14.T1;

public abstract class Animal
{
    public abstract string Name { get; init; }

    protected Animal(string name)
    {
        Name = name;
    }

    public virtual string Say() => "";

    public void ShowInfo() => Console.WriteLine($"Меня зовут {Name}. Я умею говорить: {Say()}");

}