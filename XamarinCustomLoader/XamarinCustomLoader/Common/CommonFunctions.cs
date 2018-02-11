using Xamarin.Forms;
using XamarinCustomLoader.Interfaces;

namespace XamarinCustomLoader.Common
{
    public static class CommonFunctions
    {
        public static HtmlWebViewSource GetLoaderSource()
        {
            var loaderSource = new HtmlWebViewSource
            {
                Html = @"<html><body bgcolor='#87ceeb'style='margin: 0; padding: 0'><img src='loading.gif'style='width: 60px; height:60px; ' /></body></html>",

                BaseUrl = DependencyService.Get<IGif>().GetGifImageUrl()
            };

            return loaderSource;
        }
    }
}