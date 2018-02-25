using Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimpleInjectionData.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IYoutubeService _service;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(IYoutubeService service)
        {
            _service = service;

#if DEBUG
            if (ViewModelLocator.UseDesignTimeData)
            {
                Refresh();
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
                if (_result == value)
                {
                    return;
                }

                _result = value;
                RaisePropertyChanged();
            }
        }

        public async Task Refresh()
        {
            Result = await _service.Refresh();
        }

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}