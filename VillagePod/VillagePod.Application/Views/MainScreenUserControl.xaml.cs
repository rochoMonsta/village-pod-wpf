using System.Windows;
using System.Windows.Controls;
using VillagePod.Application.ViewModels;
using VillagePod.Persistence.Models;

namespace VillagePod.Application.Views
{
    public partial class MainScreenUserControl : UserControl
    {
        private MainScreenViewModel? _mainScreenViewModel;
        public MainScreenUserControl(PosDeviceRepresenter selectedPos)
        {
            _mainScreenViewModel = new MainScreenViewModel(selectedPos);
            DataContext = _mainScreenViewModel;
            InitializeComponent();
        }
    }
}
