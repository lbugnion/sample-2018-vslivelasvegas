using Data;
using SimpleInjection.Data.Design;

namespace SimpleInjectionData.ViewModel
{
    public class ViewModelLocator
    {
        public const bool UseDesignTimeData = true;

        private MainViewModel _main;

        public MainViewModel Main
        {
            get
            {
                IYoutubeService service;

#if DEBUG
                if (UseDesignTimeData)
                {
                    service = new DesignYoutubeService();
                }
                else
                {
#endif
                    service = new YoutubeService();
#if DEBUG
                }
#endif

                return _main ?? (_main = new MainViewModel(service));
            }
        }
    }
}