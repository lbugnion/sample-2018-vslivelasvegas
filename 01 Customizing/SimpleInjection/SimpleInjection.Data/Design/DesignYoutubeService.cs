using Data;
using System.Threading.Tasks;

namespace SimpleInjection.Data.Design
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
