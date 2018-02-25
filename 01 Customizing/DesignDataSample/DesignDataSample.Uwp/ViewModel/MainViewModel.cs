using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DesignDataSample.Uwp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private QuoteService _service;

        public string Title
        {
            get
            {
                return "Shakespeare quotes";
            }
        }

        private IList<string> _quotes;

        public IList<string> Quotes
        {
            get
            {
                return _quotes;
            }

            set
            {
                if (_quotes == value)
                {
                    return;
                }

                _quotes = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            _service = new QuoteService();
        }

        public async Task Refresh()
        {
            Quotes = await _service.GetQuotes();
        }

        #region INPC Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
