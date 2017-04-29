using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamagram.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamagram.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamagramItemDetailView : ContentPage
    {
        public XamagramItemDetailView(object parameter)
        {
            InitializeComponent();
            Parameter = parameter;
            BindingContext = new XamagramItemDetailViewModel();
        }

        public object Parameter { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var viewModel = BindingContext as XamagramItemDetailViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }
    }
}
