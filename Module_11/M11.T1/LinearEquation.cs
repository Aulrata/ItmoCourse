namespace M11.T1;

public struct LinearEquation
{
    private readonly double _k;
    private readonly double _b;

    public LinearEquation(double k, double b)
    {
        _k = k;
        _b = b;
    }

    public double Root() => -_b / _k;
}