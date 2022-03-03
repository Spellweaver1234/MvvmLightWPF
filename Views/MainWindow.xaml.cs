using System.Windows;

using WpfMvvmLight.ViewModel;

namespace WpfMvvmLight.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
