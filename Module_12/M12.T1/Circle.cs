namespace M12.T1;

public static class Circle
{
    public static double GetLength(double radius) => 2 * radius * Math.PI;

    public static double GetSquare(double radius) => Math.PI * Math.Pow(radius, 2);

    public static bool IsInside(double radius, double x, double y)
    {
        var length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return radius >= length;
    }
}