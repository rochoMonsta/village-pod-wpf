using System.Windows.Controls;
using VillagePod.Application.Views;
using VillagePod.Persistence.Models;
using VillagePod.Persistence.Services;

namespace VillagePod.Application.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl? _selectedView;
        private ScreenSizePreset? _selectedScreenSizePreset;

        public MainViewModel()
        {
            InitializeApplication();
        }

        public UserControl? SelectedView
        {
            get => _selectedView;
            set { _selectedView = value; OnPropertyChanged(nameof(SelectedView)); }
        }

        public ScreenSizePreset? SelectedScreenSizePreset
        {
            get => _selectedScreenSizePreset;
            set { _selectedScreenSizePreset = value; OnPropertyChanged(nameof(SelectedScreenSizePreset)); }
        }

        private void InitializeApplication()
        {
            SelectedView = new AuthenticationUserControl();
            SelectedScreenSizePreset = new LoginPageScreenPreset();
            ApplicationManager.OnLoginEvent += OnLoginEventHandler;
            ApplicationManager.OnLogoutEvent += OnLogoutEventHandler;
            ApplicationManager.OnPosDeviceSelectedEvent += OnPosDeviceSelectedEventHandler;
        }

        private void OnPosDeviceSelectedEventHandler(PosDeviceRepresenter selectedPos)
        {
            SelectedScreenSizePreset = new MainPageScreenPreset();
            SelectedView = new MainScreenUserControl(selectedPos);
        }

        private void OnLogoutEventHandler()
        {
            SelectedScreenSizePreset = new LoginPageScreenPreset();
            SelectedView = new AuthenticationUserControl();
        }

        private void OnLoginEventHandler()
        {
            SelectedScreenSizePreset = new LoginPageScreenPreset();
            SelectedView = new SystemSelectionUserControl();
        }
    }
}
