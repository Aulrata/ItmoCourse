// See https://aka.ms/new-console-template for more information

using M19.T1;

Console.WriteLine("Hello, World!");

IEnumerable<Computer> computers = new List<Computer>()
{
    new Computer(1, "Asus", ProcessorType.Amd, 4.5, 16, 1000, 16, 10000.32, 10),
    new Computer(2, "Asus", ProcessorType.Amd, 4.5, 8, 1000, 16, 1000000, 1000),
    new Computer(3, "Asus", ProcessorType.Intel, 4.5, 16, 1000, 16, 1000032, 130),
    new Computer(4, "Huawei", ProcessorType.Intel, 4.5, 12, 1000, 16, 1000, 1120),
    new Computer(5, "Huawei", ProcessorType.Intel, 4.5, 32, 1000, 16, 1123, 3210),
    new Computer(6, "Huawei", ProcessorType.Amd, 4.5, 8, 1000, 16, 100, 110),
    new Computer(7, "MSI", ProcessorType.Amd, 4.5, 4, 1000, 16, 133123134, 1),
    new Computer(8, "MSI", ProcessorType.Intel, 4.5, 24, 1000, 16, 1004, 1),
    new Computer(9, "MSI", ProcessorType.Amd, 4.5, 12, 1000, 16, 100.32, 0),
    new Computer(10, "Honor", ProcessorType.Amd, 4.5, 8, 1000, 16, 10.32, 20),
    new Computer(11, "Honor", ProcessorType.Intel, 4.5, 8, 1000, 16, 123000, 11),
    new Computer(12, "Honor", ProcessorType.Amd, 4.5, 4, 1000, 16, 100120, 14),
    new Computer(13, "Samsung", ProcessorType.Intel, 4.5, 4, 1000, 16, 10010, 10),
    new Computer(14, "Samsung", ProcessorType.Amd, 4.5, 32, 1000, 16, 1002300, 10),
    new Computer(15, "Samsung", ProcessorType.Intel, 4.5, 64, 1000, 16, 12300, 10),
};

Print("Изначальный список копьютеров", computers);

Console.WriteLine("Введите тип процессора: ");
var result = Console.ReadLine();

var processorType = result.ToLower() switch
{
    "intel" => ProcessorType.Intel,
    "amd" => ProcessorType.Amd,
    _ => ProcessorType.None
};

var res = computers.Where(x => x.Processor == processorType).Select(c => $"{c.Id} ");
Print($"Номера компьютеров с процессором {result}", res);

Console.WriteLine("Введите объем ОЗУ");
var ram = int.Parse(Console.ReadLine());

res = computers.Where(x => x.Ram >= ram).Select(c => $"{c.Id} ");
Print($"Номера компьютеров с ОЗУ не ниже {ram}Гб", res);

var computerOrderBy = computers.OrderBy(x => x.Price);
Print("Компьютеры отсортированные по увелечению цены", computerOrderBy);

var grouped = computers.GroupBy(x => x.Processor);
PrintGrouped("Компьютеры сгруппированные по процессору", grouped);

var maxPrice = computers.Max(x => x.Price);
var minPrice = computers.Min(x => x.Price);
Console.WriteLine($"Компьютер с минимальной ценой: {minPrice} и максимальной ценой: {maxPrice}");

var count = computers.Where(x => x.CountOfComputers >= 30).Select(s => $"{s.Id}");
Print("Номера компьютеров, которых не менее 30", count);

void Print<T>(string mes, IEnumerable<T> list)
{
    Console.WriteLine(mes);
    foreach (var item in list)
    {
        Console.WriteLine(item.ToString());
    }
}

void PrintGrouped<T>(string mes, IEnumerable<IGrouping<ProcessorType, T>> list)
{
    Console.WriteLine(mes);
    foreach (var item in list)
    {
        foreach (var item2 in item)
        {
            Console.WriteLine(item2.ToString());
        }
    }
}



