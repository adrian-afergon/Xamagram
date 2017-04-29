using Xamagram.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamagram.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewXamagramItemView : ContentPage
    {
        public NewXamagramItemView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = new NewXamagramItemViewModel();
        }

        public object Parameter { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var viewModel = BindingContext as NewXamagramItemViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }
    }
}
