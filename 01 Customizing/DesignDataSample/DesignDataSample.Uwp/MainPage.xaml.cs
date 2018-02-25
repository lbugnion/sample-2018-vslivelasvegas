using DesignDataSample.Uwp.ViewModel;
using Windows.UI.Xaml.Controls;

namespace DesignDataSample.Uwp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RefreshButtonClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await ((MainViewModel)(LayoutRoot.DataContext)).Refresh();
        }
    }
}
