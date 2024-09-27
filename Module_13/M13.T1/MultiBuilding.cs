namespace M13.T1;

public sealed class MultiBuilding : Building
{
    public int Floors { get; private set; }

    public MultiBuilding(int floors, string address, double length, double width, double height)
        : base(address, length, width, height)
    {
        Floors = floors;
    }

    public string Print() => base.Print() + $", этажей: {Floors}";
}