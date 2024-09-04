Console.WriteLine("Введите предложение");

string[] words = Console.ReadLine().Split();
string word = words[0];


foreach (var item in words)
{
    if (item.Length > word.Length)
        word = item;
}

Console.WriteLine($"Самое длинное слово это: {word}.");