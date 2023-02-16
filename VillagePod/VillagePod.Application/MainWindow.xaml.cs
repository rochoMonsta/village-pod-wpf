using System.Windows;
using VillagePod.Application.ViewModels;

namespace VillagePod.Application
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
