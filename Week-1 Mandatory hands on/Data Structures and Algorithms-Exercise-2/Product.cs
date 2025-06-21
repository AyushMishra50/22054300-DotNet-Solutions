public class Product
{
    public int PId { get; set; }
    public string PName { get; set; }
    public string C { get; set; }

    public Product(int productId, string productName, string category)
    {
        PId = productId;
        PName = productName;
        C = category;
    }
}
