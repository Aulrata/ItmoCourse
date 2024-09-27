namespace M13.T1;

public class Building
{
    public string Address { get; private set; }
    public double Length { get; private set; }
    public double Width { get; private set; }
    public double Height { get; private set; }


    public Building(string address, double length, double width, double height)
    {
        Address = address;
        Length = length;
        Width = width;
        Height = height;
    }

    public string Print() => $"Адресс: {Address}, длина: {Length}, ширина: {Width}, высота: {Height}";
    
}