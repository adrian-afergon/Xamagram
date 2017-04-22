using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamagram.ViewModels;
using Xamarin.Forms;

namespace Xamagram.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            
            BindingContext = new CitiesViewModel(this.Navigation);
            
        }
    }
}
