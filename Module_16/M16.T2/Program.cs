using System.Text.Json;
using M16.T1;

List<Product> products = new();

string json = File.ReadAllText($"D:\\{nameof(Product)}.json");

products = JsonSerializer.Deserialize<List<Product>>(json);

Console.WriteLine($"Имя самого дорогого товара: {products.First(x => x.Price == products.Max(x => x.Price)).Name}");