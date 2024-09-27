using M15.T1;

int start = 1;
int step = 2;
ArithProgression arithProgression = new(step);
arithProgression.SetStart(start);
Console.Write($"{start} ");
Console.Write($"{arithProgression.GetNext()} ");
Console.Write($"{arithProgression.GetNext()} ");
Console.Write($"{arithProgression.GetNext()} ");
Console.Write($"{arithProgression.GetNext()} ");
Console.Write($"{arithProgression.GetNext()} ");

Console.WriteLine();

GeomProgression geomProgression = new(step);
geomProgression.SetStart(start);
Console.Write($"{start} ");
Console.Write($"{geomProgression.GetNext()} ");
Console.Write($"{geomProgression.GetNext()} ");
Console.Write($"{geomProgression.GetNext()} ");
Console.Write($"{geomProgression.GetNext()} ");
Console.Write($"{geomProgression.GetNext()} ");