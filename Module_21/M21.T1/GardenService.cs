namespace M21.T1;

public class GardenService
{
    private long _rows;
    private long _columns;
    private readonly bool[,] _gardenPlots;
    private readonly int[,] _statistics;
    private long _count = 0;

    public GardenService(long rows, long columns)
    {
        _rows = rows;
        _columns = columns;
        _gardenPlots = new bool[_rows, _columns];
        _statistics = new int[_rows, _columns];
    }

    public void StartWork()
    {
        ThreadStart threadFirstStart = new(FirstGarden);
        ThreadStart threadSecondStart = new(SecondGarden);
        Thread first = new(threadFirstStart);
        Thread second = new(threadSecondStart);
        first.Start();
        second.Start();
        StatisticsOfGarden();
    }
    
    private void FirstGarden()
    {
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                if (_gardenPlots[i, j]) continue;

                _gardenPlots[i, j] = true;
                _statistics[i, j] = 1;
                _count++;
                Thread.Sleep(1000 * 1);
            }
        }
    }
    
    private void SecondGarden()
    {
        for (long i = _columns - 1; i >= 0; i--)
        {
            for (long j = _rows - 1; j >= 0; j--)
            {
                if (_gardenPlots[j, i]) continue;

                _gardenPlots[j, i] = true;
                _statistics[j, i] = 2;
                _count++;
                Thread.Sleep(1000 * 1);
            }
        }
    }

    private void StatisticsOfGarden()
    {
        while (_count < _rows * _columns)
        {
            Console.Clear();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{_statistics[i, j]} ");
                }

                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }
    }
}