using DesignDataSample.Uwp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignDataSample.Uwp.ViewModel
{
    public class QuoteService
    {
        public Task<IList<string>> GetQuotes()
        {
            // This is where we would get quotes from a data source

            var list = new List<string>
            {
                "Love all, trust a few, do wrong to none.",
                "You speak an infinite deal of nothing.",
                "With mirth and laughter let old wrinkles come.",
                "Conscience doth make cowards of us all.",
                "Et tu, Brute?",
                "Wisely and slow; they stumble that run fast.",
                "Some are born great, others achieve greatness"
            };

            // Return in random order
            list.Shuffle();

            return Task.FromResult((IList<string>)list);
        }
    }
}