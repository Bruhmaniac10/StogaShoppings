using System.Collections.ObjectModel;
using System.Linq;

namespace StogaShopping
{
    public class CartPage
    {
        public ObservableCollection<Product> CartItems { get; set; }

        public CartViewModel()
        {
            // Initialize your CartItems collection
            CartItems = new ObservableCollection<Product>();
        }

        public void AddToCart(Product product)
        {
            CartItems.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            // Remove the product from the cart
            CartItems.Remove(product);
        }
    }
}
