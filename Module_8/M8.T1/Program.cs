// Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и
// содержимое всех подкаталогов.

Console.WriteLine("Введите путь: ");
string startDirectory = Console.ReadLine();

if (!Directory.Exists(startDirectory))
{
    Console.WriteLine("Directory doesn't exist!");
    return;
}

ShowTree(startDirectory);

void ShowTree(string path, string spaces = "")
{
    var directory = new DirectoryInfo(path);

    Console.WriteLine(spaces + directory.Name);
    
    foreach (var item in directory.GetDirectories())
    {
        ShowTree(item.FullName, spaces + "--");
    }

    foreach (var item in directory.GetFiles())
    {
        Console.WriteLine(spaces + "--" + item.Name);
    }
}
 