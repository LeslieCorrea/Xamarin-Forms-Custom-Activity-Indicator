using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCustomLoader.Common;

namespace XamarinCustomLoader.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressDialog : Grid
    {
        public ProgressDialog()
        {
            InitializeComponent();

            Loader.Source = CommonFunctions.GetLoaderSource();
        }
    }
}