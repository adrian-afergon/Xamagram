using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamagram.Models;
using Xamagram.Services;
using Xamagram.ViewModels.Base;
using Xamagram.Views;
using Xamarin.Forms;

namespace Xamagram.ViewModels
{
    class CitiesViewModel : ViewModelBase
    {
        public ObservableCollection<City> Cities { get; set; }
        private ObservableCollection<XamagramItem> _items;

        public ObservableCollection<XamagramItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public City selectedCity {

            get
            {
                return selectedCity;
            }
            set
            {
                if (value != null)
                {
                    _navigation.PushAsync(new DetailsView(value.id));
                }
            } } 

        private INavigation _navigation;
        public ICommand NavigateCommand { set; get; }

        public CitiesViewModel(INavigation navigation)
        {
            _navigation = navigation;
            initialiceList(); 
        }

        private void initialiceList() {
            Cities = new ObservableCollection<City>();
            List<City> citiesFromService = CitiesServices.getCities("token");
            foreach (City city in citiesFromService)
            {
                Cities.Add(city);
            }
        }


    }
}
