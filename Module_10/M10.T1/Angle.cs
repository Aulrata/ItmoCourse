namespace M10.T1;

public class Angle
{
    private double _degree;
    private int _minutes;
    private int _seconds;

    public double Degree
    {
        get => _degree;

        private set => _degree = value < 0 ? 0 : value;
    }

    public int Minutes
    {
        get => _minutes;

        private set
        {
            if (value < 0)
            {
                _minutes = 0;
            }
            else
            {
                _minutes = value % 60;
                // ReSharper disable once PossibleLossOfFraction
                Degree += value / 60;
            }
        }
    }

    public int Seconds
    {
        get => _seconds;

        private set
        {
            if (value < 0)
            {
                _seconds = 0;
            }
            else
            {
                _seconds = value % 60;
                Minutes += value / 60;
            }
        }
    }

    public Angle(double degree, int minutes, int seconds)
    {
        Seconds += seconds;
        Minutes += minutes;
        Degree += degree;
    }

    public double ToRadians() => (_degree + (_minutes + _seconds / 60.0) / 60.0) * Math.PI / 180;
}