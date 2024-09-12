const string path = "text.txt";

if (!File.Exists(path))
{
    Console.WriteLine("Файла не существует, создайте файл");
    return;
}

int countOfStrings = 0, countOfWords = 0, countOfSymbols = 0;

using (StreamReader sr = new(path))
{
    while (!sr.EndOfStream)
    {
        var text = sr.ReadLine() ?? string.Empty;
        countOfSymbols += text.Length;
        countOfWords += text.Split(' ').Count(s => s != "");    // Не знаю можно ли так на этом этапе курсе, но мне показалось это красивым решением. Если нужно без LINQ, то могу переделать
        countOfStrings++;
    }
    
}

Console.WriteLine($"Количество строк: {countOfStrings}, количество слов: {countOfWords}, количество символов: {countOfSymbols}");