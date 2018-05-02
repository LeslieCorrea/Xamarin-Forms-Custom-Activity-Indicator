using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCustomLoader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnSimpleLoaderButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomLoaderExamplePage());
        }

        public async void LoaderWithBlurEffectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomLoaderWithBlurEffect());
        }
    }
}