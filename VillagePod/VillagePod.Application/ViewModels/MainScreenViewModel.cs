using VillagePod.Persistence.Models;
using VillagePod.Persistence.Services;
using static VillagePod.Utility.Helpers.ApplicationEnums;

namespace VillagePod.Application.ViewModels
{
    public class MainScreenViewModel : ViewModelBase
    {
        private PosDeviceRepresenter _selectedPos;
        private PosConnectionStatus _posConnectionStatus;
        private RelayCommand? _logoutCommand;
        private RelayCommand? _changePosCommand;
        private RelayCommand? _showLogsCommand;
        private RelayCommand? _showHelpCommand;
        private RelayCommand? _updateCommand;
        private RelayCommand? _reconnectCommand;

        public MainScreenViewModel(PosDeviceRepresenter selectedPos)
        {
            Initialize(selectedPos);
        }

        public PosDeviceRepresenter SelectedPos
        {
            get => _selectedPos;
            set { _selectedPos = value; OnPropertyChanged(nameof(SelectedPos)); }
        }

        public PosConnectionStatus PosConnectionStatus
        {
            get => _posConnectionStatus;
            set { _posConnectionStatus = value; OnPropertyChanged(nameof(PosConnectionStatus)); }
        }

        public RelayCommand? LogoutCommand =>
           _logoutCommand ?? (_logoutCommand = new RelayCommand(LogoutCommandHandler));

        public RelayCommand? ChangePosCommand =>
           _changePosCommand ?? (_changePosCommand = new RelayCommand(ChangePosCommandHandler));

        public RelayCommand? ShowLogsCommand =>
            _showLogsCommand ?? (_showLogsCommand = new RelayCommand(ShowLogsCommandHandler));

        public RelayCommand? ShowHelpCommand =>
            _showHelpCommand ?? (_showHelpCommand = new RelayCommand(ShowHelpCommandHandler));

        public RelayCommand? UpdateCommand =>
            _updateCommand ?? (_updateCommand = new RelayCommand(UpdateCommandHandler));

        public RelayCommand? ReconnectCommand =>
            _reconnectCommand ?? (_reconnectCommand = new RelayCommand(ReconnectCommandHandler));

        private void Initialize(PosDeviceRepresenter selectedPos)
        {
            SelectedPos = selectedPos;
            PosConnectionStatus = PosConnectionStatus.Connected;
        }

        private void LogoutCommandHandler(object obj)
        {
            ApplicationManager.ExecuteOnLogoutEvent();
        }

        private void ChangePosCommandHandler(object obj)
        {
            ApplicationManager.ExecuteOnLoginEvent();
        }

        private void ShowLogsCommandHandler(object obj)
        {

        }

        private void ShowHelpCommandHandler(object obj)
        {

        }

        private void UpdateCommandHandler(object obj)
        {

        }

        private void ReconnectCommandHandler(object obj)
        {

        }
    }
}
