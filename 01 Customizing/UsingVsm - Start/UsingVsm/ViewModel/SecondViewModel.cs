using System.Collections.Generic;
using Windows.UI.Xaml;

namespace UsingVsm.ViewModel
{
    public class SecondViewModel
    {
        public List<string> Quotes
        {
            get
            {
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

                return list;
            }
        }
    }
}
