namespace StogaShopping;

public class Cart
{
    public static Cart instance;

    public static Cart Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Cart();
            }
            return instance;
        }
    }
    public List<Product> CartItems { get; private set; }

    public Cart()
    {
        CartItems = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        // Add the product to the cart
        CartItems.Add(product);
    }
}

