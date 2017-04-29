using Xamarin.Forms;

namespace Xamagram.ViewModels.Base
{
    class ViewModelBase : BindableObject
    {
        public virtual void OnAppearing(object navigationContext)
        {
        }

        public virtual void OnDisappearing()
        {
        }
    }
}
