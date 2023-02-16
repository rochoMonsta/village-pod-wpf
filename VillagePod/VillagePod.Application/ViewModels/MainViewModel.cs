namespace VillagePod.Application.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _selectedView;

        public MainViewModel()
        {
            SelectedView = new AuthenticationViewModel();
        }

        public ViewModelBase? SelectedView
        {
            get => _selectedView;
            set { _selectedView = value; OnPropertyChanged(nameof(SelectedView)); }
        }
    }
}
