using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace StogaShopping
{
    public partial class ShoppingPage
    {
        private readonly ShoppingPageViewModel _viewModel;
        private ObservableCollection<Product> products;
        private ObservableCollection<Product> originalProducts;
        public ShoppingPage()
        {
            InitializeComponent();
            BindingContext = new ProductPage();
            originalProducts = new ObservableCollection<Product>();
            products = new ObservableCollection<Product>(originalProducts);
            ((ProductPage)BindingContext).InitialProductList();
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadData();
        }

        private async void ShoppingClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        private async void MusicClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusicDisplay());
        }

        private async void DealsClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DealsPage());
        }

        private async void SellClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SellPage());
        }
        private async void CartClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage());
        }

        private async void AccountClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }

        private async void HelpClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }

        private void AddToCartButtonClicked(object sender, EventArgs e)
        {
            ProductPage.AddToCartClicked(sender, e);
        }
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue;
            UpdateProductList(searchText);
        }

        private void UpdateProductList(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                collectionView.ItemsSource = originalProducts;
            }
            else
            {
                var filteredProducts = new ObservableCollection<Product>();

                foreach (var product in originalProducts)
                {
                    if (product.Name.ToLower().Contains(searchText.ToLower()))
                    {
                        filteredProducts.Add(product);
                    }
                }

                collectionView.ItemsSource = filteredProducts;
            }
        }




    }
}