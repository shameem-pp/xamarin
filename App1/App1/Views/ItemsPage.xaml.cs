using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            browser.Source = "file:///android_asset/local.html";
        }

        private async void browserNavigated(object sender, WebNavigatedEventArgs e)
        {
            var content = "content from c#";

            await browser.EvaluateJavaScriptAsync($"insert('{content}')");
        }
    }
}