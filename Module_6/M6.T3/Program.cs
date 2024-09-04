Console.WriteLine("Введите строку");
string str = Console.ReadLine();
int openBraceCount = 0;
int closeBraceCount = 0;
string newStr = "";

foreach (char c in str)
{
    if (c == '{')
        openBraceCount++;
    else if (c == '}')
        closeBraceCount++;

    if (openBraceCount == closeBraceCount)
    {
        if (openBraceCount != 0)
        {
            openBraceCount = 0;
            closeBraceCount = 0;
        }
        else
            newStr += c;
    }
    
}

Console.WriteLine(newStr);
