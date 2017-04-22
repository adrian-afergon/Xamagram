using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamagram.ViewModels;
using Xamarin.Forms;

namespace Xamagram.Views
{
    public partial class DetailsView : ContentPage
    {
        /*
        public DetailsView()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }*/

        public DetailsView(String id) {
            InitializeComponent();
            BindingContext = new DetailsViewModel(id);
        }
    }
}
