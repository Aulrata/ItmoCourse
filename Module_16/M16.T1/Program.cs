using System.Text.Json;
using M16.T1;

Console.WriteLine("Введите количество товаров");
int numberOfProducts = int.Parse(Console.ReadLine());
List<Product> products = [];


for (int i = 0; i < numberOfProducts; i++)
{
    Console.WriteLine("Введите номер товара");    
    int productId = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите имя товара");
    string name = Console.ReadLine();

    Console.WriteLine("Ввидете цену товара");
    double price = double.Parse(Console.ReadLine());
    
    products.Add(new Product(productId, name ?? "Неизвестно", price));
}

JsonSerializerOptions options = new()
{
    WriteIndented = true
};

string json = JsonSerializer.Serialize(products, options);

File.AppendAllText($"D:\\{nameof(Product)}.json", json);


