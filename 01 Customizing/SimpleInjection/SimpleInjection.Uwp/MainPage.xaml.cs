using SimpleInjectionData.ViewModel;
using Windows.UI.Xaml.Controls;

namespace SimpleInjection.Uwp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RefreshButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await ((MainViewModel)DataContext).Refresh();
        }
    }
}
