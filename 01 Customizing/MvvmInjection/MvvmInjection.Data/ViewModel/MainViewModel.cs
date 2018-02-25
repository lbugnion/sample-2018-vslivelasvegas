using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MvvmInjection.Data.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IYoutubeService _service;

        public MainViewModel(IYoutubeService service)
        {
            _service = service;

#if DEBUG
            if (ViewModelLocator.UseDesignTimeData)
            {
                RefreshCommand.Execute(null);
            }
#endif
        }

        private string _result = "Nothing yet";

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                Set(ref _result, value);
            }
        }

        private RelayCommand _refreshCommand;

        public RelayCommand RefreshCommand
        {
            get
            {
                return _refreshCommand
                    ?? (_refreshCommand = new RelayCommand(
                    async () =>
                    {
                        Result = await _service.Refresh();
                    }));
            }
        }
    }
}