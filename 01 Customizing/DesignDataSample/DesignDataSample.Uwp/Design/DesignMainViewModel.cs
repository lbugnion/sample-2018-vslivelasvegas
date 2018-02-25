using System.Collections.Generic;

namespace DesignDataSample.Uwp.Design
{
    public class DesignMainViewModel
    {
        public string Title
        {
            get
            {
                return "This is for design time";
            }
        }

        public IList<string> Quotes
        {
            get
            {
                return new List<string>
                {
                    "This is a design time quote",
                    "Short",
                    "And this is a super long quote which we use to check if the Text elements are wrapping correctly one two three four five"
                };
            }
        }
    }
}
