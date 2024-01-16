namespace StogaShopping
{
    public partial class LandingPage : TabbedPage
    {
        public LandingPage()
        {
            InitializeComponent();
            this.Children.Add(new ShoppingPage());
            this.Children.Add(new CartPage());
            this.Children.Add(new Music_Page());
            this.Children.Add(new DealsPage());
            this.Children.Add(new SellPage());
            this.Children.Add(new HelpPage());
        }
    }
}
