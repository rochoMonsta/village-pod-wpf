using System.Windows.Controls;
using VillagePod.Application.Views;

namespace VillagePod.Application.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl? _selectedView;

        public MainViewModel()
        {
            SelectedView = new AuthenticationUserControl();
        }

        public UserControl? SelectedView
        {
            get => _selectedView;
            set { _selectedView = value; OnPropertyChanged(nameof(SelectedView)); }
        }
    }
}
