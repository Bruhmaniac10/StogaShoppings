using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
namespace StogaShopping
{
    public partial class SearchViewModel : ContentPage
    {
        private string _searchQuery;
        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                _searchQuery = value;

                OnPropertyChanged();
            }
        }

        private ObservableCollection<Product> _searchResults;
        public ObservableCollection<Product> SearchResults
        {
            get => _searchResults;
            set
            {
                _searchResults = value;
                OnPropertyChanged();
            }
        }

        private bool _isSmallChecked;
        public bool IsSmallChecked
        {
            get => _isSmallChecked;
            set
            {
                _isSmallChecked = value;
                OnPropertyChanged();
            }
        }



        public SearchViewModel()
        {

            SearchResults = new ObservableCollection<Product>(GetInitialResults());
        }

        private List<Product> GetInitialResults()
        {
            return null;
        }
    }
}