using MvvmInjection.Data.ViewModel;

namespace MvvmInjection.Droid
{
    public class App
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
    }
}