namespace VillagePod.Persistence.Models
{
    public class PosDeviceRepresenter : BaseNotifyModel
    {
        private int _posId;
        private string? _posName;
        private bool _isSelected = false;

        public int PosId
        {
            get => _posId;
            set { _posId = value; OnPropertyChanged(nameof(PosId)); }
        }
        public string? PosName
        {
            get => _posName;
            set { _posName = value; OnPropertyChanged(nameof(PosName)); }
        }
        public bool IsSelected
        {
            get => _isSelected;
            set { _isSelected = value; OnPropertyChanged(nameof(IsSelected)); }
        }
    }
}
