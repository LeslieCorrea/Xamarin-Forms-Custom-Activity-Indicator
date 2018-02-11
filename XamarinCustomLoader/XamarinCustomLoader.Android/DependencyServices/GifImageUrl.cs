using XamarinCustomLoader.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinCustomLoader.Droid.DependencyServices.GifImageUrl))]

namespace XamarinCustomLoader.Droid.DependencyServices
{
    public class GifImageUrl : IGif
    {
        public string GetGifImageUrl()
        {
            return "file:///android_asset/";
        }
    }
}