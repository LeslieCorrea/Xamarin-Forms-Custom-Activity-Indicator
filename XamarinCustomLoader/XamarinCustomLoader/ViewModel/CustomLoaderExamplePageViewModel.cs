using Xamarin.Forms;
using MvvmHelpers;
using System.Threading.Tasks;
using System;
using System.Windows.Input;

namespace XamarinCustomLoader.ViewModel
{
    public class CustomLoaderExamplePageViewModel : BaseViewModel
    {
        public ICommand ButtonClicked { get; }

        public CustomLoaderExamplePageViewModel()
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