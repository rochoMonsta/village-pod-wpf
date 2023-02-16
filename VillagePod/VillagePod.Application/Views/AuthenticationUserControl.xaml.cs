using System.Windows.Controls;
using VillagePod.Application.ViewModels;

namespace VillagePod.Application.Views
{
    public partial class AuthenticationUserControl : UserControl
    {
        private AuthenticationViewModel? _authenticationViewModel;

        public AuthenticationUserControl()
        {
            _authenticationViewModel ??= new AuthenticationViewModel();
            DataContext = _authenticationViewModel;
            InitializeComponent();
        }
    }
}
