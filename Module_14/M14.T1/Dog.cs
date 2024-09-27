namespace M14.T1;

public class Dog : Animal
{
    public override string Name { get; init; }
    
    public Dog(string name) 
        : base(name) {}

    public override string Say() => "Гав";
    
}