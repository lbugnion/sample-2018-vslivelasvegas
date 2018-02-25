using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MvvmInjection.Data.Design;

namespace MvvmInjection.Data.ViewModel
{
    public class ViewModelLocator
    {
        public static readonly bool UseDesignTimeData = true;

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (UseDesignTimeData)
            {
                SimpleIoc.Default.Register<IYoutubeService, DesignYoutubeService>();
            }
            else
            {
                SimpleIoc.Default.Register<IYoutubeService, YoutubeService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
    }
}