using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCustomLoader.ViewModel;

namespace XamarinCustomLoader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLoaderExamplePage : ContentPage
    {
        public CustomLoaderExamplePage()
        {
            InitializeComponent();
            var _ViewModel = BindingContext = new CustomLoaderExamplePageViewModel();
        }
    }
}