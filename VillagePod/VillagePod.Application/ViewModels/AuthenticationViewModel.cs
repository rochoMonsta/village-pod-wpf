using VillagePod.Persistence.Models;
using VillagePod.Persistence.Services;
using VillagePod.Persistence.Services.Interfaces;
using VillagePod.Utility.Helpers;

namespace VillagePod.Application.ViewModels
{
    public class AuthenticationViewModel : ViewModelBase
    {
        #region Fields
        private string? _login;
        private string? _password;
        private bool _isAuthenticated;
        private IEncryptedCredentialService _encryptedCredentialService;

        private RelayCommand? _authenticateUserCommand;
        private RelayCommand? _logoutUserCommand;
        #endregion

        public AuthenticationViewModel()
        {
            _encryptedCredentialService ??= new EncryptedCredentialService();
            SetAccountInformation();
        }

        #region Properties
        public string? Login
        {
            get => _login;
            set { _login = value; OnPropertyChanged(nameof(Login)); }
        }

        public string? Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set { _isAuthenticated = value; OnPropertyChanged(nameof(IsAuthenticated)); }
        }
        #endregion

        #region Commands
        public RelayCommand? AuthenticateUserCommand =>
            _authenticateUserCommand ?? (_authenticateUserCommand = new RelayCommand(AuthenticateUserCommandHandler));

        public RelayCommand? LogoutUserCommand =>
            _logoutUserCommand ?? (_logoutUserCommand = new RelayCommand(LogoutUserCommandHandler));
        #endregion

        #region Command handlers
        private void AuthenticateUserCommandHandler(object obj)
        {
            // call your endpoint wrapper here and check result

            var accountCredential = new AccountCredentialModel()
            {
                CredentialKey = ApplicationConstants.CREDENTIAL_KEY,
                Login = Login,
                Password = Password
            };

            var result = _encryptedCredentialService.SaveEncryptedCredential(accountCredential);

            if (result)
                IsAuthenticated = true;

            if (IsAuthenticated)
                ApplicationManager.ExecuteOnLoginEvent();
        }

        private void LogoutUserCommandHandler(object obj)
        {
            _encryptedCredentialService.DeleteEncryptedCredential(ApplicationConstants.CREDENTIAL_KEY);
            Login = null;
            Password = null;
            IsAuthenticated = false;
        }
        #endregion

        #region Private methods
        private void SetAccountInformation()
        {
            var accountInfo = _encryptedCredentialService.GetEncryptedCredential(ApplicationConstants.CREDENTIAL_KEY);
            
            if (accountInfo != null)
            {
                Login = accountInfo.Login;
                Password = accountInfo.Password;
            }

            // call your endpoint wrapper here and check result
        }
        #endregion
    }
}
