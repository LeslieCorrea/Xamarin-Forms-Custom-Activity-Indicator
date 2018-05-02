using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinCustomLoader.ViewModel
{
    public class CustomLoaderWithBlurEffectViewModel : BaseViewModel
    {
        public ICommand ButtonClicked { get; }

        public CustomLoaderWithBlurEffectViewModel()
        {
            ButtonClicked = new Command(async () => await ShowLoader());
        }

        private async Task ShowLoader()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            await Task.Delay(1000);
            IsBusy = false;
        }
    }
}