namespace Post.Models;

public class Customer
{
    private static int IdCount { get; set; }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public Customer(string name, string city)
    {
        IdCount++;
        Id = IdCount;
        Name = name;
        City = city;
    }

}
