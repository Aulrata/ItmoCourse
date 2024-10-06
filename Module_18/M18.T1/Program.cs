
string str = "([]{})[]";
bool flag = true;

Stack<char> stack = new Stack<char>();

foreach (var item in str)
{
    if (item is '(' or '{' or '[')
    {
        stack.Push(item);
        continue;
    }

    if ((item == '[' && stack.Pop() != ']') || (item == '(' && stack.Pop() != ')') || (item == '{' && stack.Pop() != '}'))
    {
        flag = false;
        break;
    }
}

if (stack.Count != 0)
    flag = false;

Console.WriteLine(flag ? "Правильная скобочная последовательность" : "Не правильная скобочная последовательность");