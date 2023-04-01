using VillagePod.Utility.Helpers;

namespace VillagePod.Persistence.Models
{
    public class MainPageScreenPreset : ScreenSizePreset
    {
        public override int Width => ApplicationConstants.MAIN_PAGE_WIDTH_SIZE;

        public override int Height => ApplicationConstants.MAIN_PAGE_HEIGHT_SIZE;

        public override int MinWidth => ApplicationConstants.MAIN_PAGE_MINWIDTH_SIZE;

        public override int MinHeight => ApplicationConstants.MAIN_PAGE_MINHEIGHT_SIZE;

        public override int MaxWidth => ApplicationConstants.MAIN_PAGE_MAXWIDTH_SIZE;

        public override int MaxHeight => ApplicationConstants.MAIN_PAGE_MAXHEIGHT_SIZE;
    }
}
