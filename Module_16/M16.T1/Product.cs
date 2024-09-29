using System.Text.Json.Serialization;

namespace M16.T1;

public class Product
{
    [JsonPropertyName("productId")]
    public int ProductId { get; private set; }
    
    [JsonPropertyName("name")]
    public string Name { get; private set; }
    
    [JsonPropertyName("price")]
    public double Price { get; private set; }

    public Product(int productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }
}