namespace VillagePod.Persistence.Models
{
    public abstract class ScreenSizePreset
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract int MinWidth { get; }
        public abstract int MinHeight { get; }
        public abstract int MaxWidth { get; }
        public abstract int MaxHeight { get; }
    }
}
