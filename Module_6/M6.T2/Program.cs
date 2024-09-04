Console.WriteLine("Введите фразу");
string phrase = Console.ReadLine().ToLower().Replace(" ", "");
bool isPalindrome = true;
int l = 0, r = phrase.Length - 1;

while (l <= r)
{
    if (phrase[l] != phrase[r])
    {
        isPalindrome = false;
        break;
    }

    l++;
    r--;
}

Console.WriteLine(isPalindrome ? "Строка является полиндромом" : "Строка не является полиндромом");