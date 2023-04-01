using System.Windows.Controls;
using VillagePod.Application.ViewModels;

namespace VillagePod.Application.Views
{
    public partial class SystemSelectionUserControl : UserControl
    {
        private SystemSelectionViewModel? _systemSelectionViewModel;

        public SystemSelectionUserControl()
        {
            _systemSelectionViewModel ??= new SystemSelectionViewModel();
            DataContext = _systemSelectionViewModel;
            InitializeComponent();
        }
    }
}
