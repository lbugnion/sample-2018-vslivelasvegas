using System.Threading.Tasks;

namespace MvvmInjection.Data
{
    public interface IYoutubeService
    {
        Task<string> Refresh();
    }
}