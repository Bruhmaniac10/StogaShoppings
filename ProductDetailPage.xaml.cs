using System.Collections.ObjectModel;
using System.ComponentModel;

namespace StogaShopping;

public class ShoppingPageViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Product> _products;

    public ObservableCollection<Product> Products
    {
        get => _products;
        set
        {
            _products = value;
            OnPropertyChanged(nameof(Products));
        }
    }

    public async Task LoadData()
    {
        var productDatabase = new ProductDatabase();
        var products = await productDatabase.GetProductsAsync();
        Products = new ObservableCollection<Product>(products);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
