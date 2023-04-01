using System.Collections.ObjectModel;
using System.Linq;
using VillagePod.Persistence.Models;
using VillagePod.Persistence.Services;
using VillagePod.Utility.Helpers;

namespace VillagePod.Application.ViewModels
{
    public class SystemSelectionViewModel : ViewModelBase
    {
        private PosDeviceRepresenter _selectedPosDevice;
        private ObservableCollection<PosDeviceRepresenter> _posDeviceRepresenters;
        private RelayCommand? _nextUserCommand;

        public SystemSelectionViewModel()
        {
            Initialize();
        }

        public PosDeviceRepresenter SelectedPosDevice
        {
            get => _selectedPosDevice;
            set { _selectedPosDevice = value; OnPropertyChanged(nameof(SelectedPosDevice)); }
        }

        public ObservableCollection<PosDeviceRepresenter> PosDeviceRepresenters
        {
            get => _posDeviceRepresenters;
            set { _posDeviceRepresenters = value; OnPropertyChanged(nameof(PosDeviceRepresenters)); }
        }

        public RelayCommand? NextUserCommand =>
            _nextUserCommand ?? (_nextUserCommand = new RelayCommand(NextCommandHandler));

        private void Initialize()
        {
            SelectedPosDevice = null;
            // Here you need to call the method that receives the POS system and format it into objects of the PosDeviceRepresenter class
            PosDeviceRepresenters = new ObservableCollection<PosDeviceRepresenter>()
            {
                new PosDeviceRepresenter(){ PosId = 1, PosName = "Pos Device #1" },
                new PosDeviceRepresenter(){ PosId = 2, PosName = "Pos Device #2" },
                new PosDeviceRepresenter(){ PosId = 3, PosName = "Pos Device #3" },
                new PosDeviceRepresenter(){ PosId = 4, PosName = "Pos Device #4" },
                new PosDeviceRepresenter(){ PosId = 5, PosName = "Pos Device #5" },
                new PosDeviceRepresenter(){ PosId = 6, PosName = "Pos Device #6" },
                new PosDeviceRepresenter(){ PosId = 7, PosName = "Pos Device #7" },
                new PosDeviceRepresenter(){ PosId = 8, PosName = "Pos Device #8" },
                new PosDeviceRepresenter(){ PosId = 9, PosName = "Pos Device #9" },
            };

            if (PosDeviceRepresenters.Count() == ApplicationConstants.SINGLE_POS)
            {
                SelectedPosDevice = PosDeviceRepresenters.First();
                ApplicationManager.ExecuteOnPosDeviceSelectedEvent(SelectedPosDevice);
            }
        }

        private void NextCommandHandler(object obj)
        {
            ApplicationManager.ExecuteOnPosDeviceSelectedEvent(SelectedPosDevice);
        }
    }
}
