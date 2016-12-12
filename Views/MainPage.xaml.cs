using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace School.OnlineBookingSystem.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MenuListBoxItem_OnTapped(object sender, RoutedEventArgs routedEventArgs)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

       
    }
}
