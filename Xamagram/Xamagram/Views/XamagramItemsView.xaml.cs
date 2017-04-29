using Xamagram.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamagram.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamagramItemsView : ContentPage
    {
        public XamagramItemsView(object parameter)
        {
            InitializeComponent();
            Parameter = parameter;
            BindingContext = new XamagramItemsViewModel();
        }

        public object Parameter { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var viewModel = BindingContext as XamagramItemsViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

    }
}
