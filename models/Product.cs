
public class Product
{
    public int id { get; set; }
    public string category { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public int price { get; set; }
    public int quantity { get; set; }
    public int totalInventory { get; set; }

    public Product(int _id, string _category, string _name, string _image, int _price, int _quantity, int _totalInventory)
    {
        id = _id;
        category = _category;
        name = _name;
        image = _image;
        price = _price;
        quantity = _quantity;
        totalInventory = _totalInventory;

        
    }
}
