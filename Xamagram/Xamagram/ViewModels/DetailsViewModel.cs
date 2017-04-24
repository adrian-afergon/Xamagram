using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamagram.Models;
using Xamagram.Services;
using Xamarin.Forms;

namespace Xamagram.ViewModels
{
    class DetailsViewModel : BindableObject
    {

        private City _city;
                    
        public City City
        {
            get { return _city; }
            set {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        private string Message { get; set; }

        public DetailsViewModel(String id)
        {
            Message = "Prueba";
            OnPropertyChanged("Message");
            City = CitiesServices.getCity("token", id);
            //OnPropertyChanged("city");
        }
    }
}
