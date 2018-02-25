using System.Threading.Tasks;

namespace MvvmInjection.Data.Design
{
    public class DesignYoutubeService : IYoutubeService
    {
        public Task<string> Refresh()
        {
            var tcs = new TaskCompletionSource<string>();
            tcs.SetResult("This is design text");
            return tcs.Task;
        }
    }
}
