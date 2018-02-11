using XamarinCustomLoader.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinCustomLoader.iOS.DependencyServices.GifImageUrl))]

namespace XamarinCustomLoader.iOS.DependencyServices
{
    public class GifImageUrl : IGif
    {
        public string GetGifImageUrl()
        {
            return Foundation.NSBundle.MainBundle.BundlePath;
        }
    }
}