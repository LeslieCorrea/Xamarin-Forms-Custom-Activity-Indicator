using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCustomLoader.Common;
using XamarinCustomLoader.ViewModel;

namespace XamarinCustomLoader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLoaderWithBlurEffect : ContentPage
    {
        public CustomLoaderWithBlurEffect()
        {
            InitializeComponent();
            var _ViewModel = BindingContext = new CustomLoaderWithBlurEffectViewModel();
            Loader.Source = CommonFunctions.GetLoaderSourceForBlurEffect();
        }
    }
}