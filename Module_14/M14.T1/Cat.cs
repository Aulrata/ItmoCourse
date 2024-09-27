namespace M14.T1;

public class Cat : Animal
{
    public override string Name { get; init; }
    
    public Cat(string name) 
        : base(name) {}

    public override string Say() => "Мяу";
}