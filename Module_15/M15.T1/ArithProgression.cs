namespace M15.T1;

public class ArithProgression : ISeries
{
    private int _startValue;
    private readonly int _step;
    private int _currentValue;    

    public ArithProgression(int step)
    {
        _step = step;
    }

    public void SetStart(int x)
    {
        _startValue = x;
        _currentValue = x;
    }

    public int GetNext() => _currentValue += _step;

    public void Reset() => _currentValue = _startValue;
}