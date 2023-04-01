using VillagePod.Utility.Helpers;

namespace VillagePod.Persistence.Models
{
    public class LoginPageScreenPreset : ScreenSizePreset
    {
        public override int Width => ApplicationConstants.LOGIN_PAGE_WIDTH_SIZE;

        public override int Height => ApplicationConstants.LOGIN_PAGE_HEIGHT_SIZE;

        public override int MinWidth => ApplicationConstants.LOGIN_PAGE_MINWIDTH_SIZE;

        public override int MinHeight => ApplicationConstants.LOGIN_PAGE_MINHEIGHT_SIZE;

        public override int MaxWidth => ApplicationConstants.LOGIN_PAGE_MAXWIDTH_SIZE;

        public override int MaxHeight => ApplicationConstants.LOGIN_PAGE_MAXHEIGHT_SIZE;
    }
}
