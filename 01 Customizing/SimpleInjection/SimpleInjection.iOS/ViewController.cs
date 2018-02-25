using SimpleInjectionData.ViewModel;
using System;

using UIKit;

namespace SimpleInjection.iOS
{
    public partial class ViewController : UIViewController
    {
        private ViewModelLocator _locator;

        public ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Locator.Main.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(MainViewModel.Result))
                {
                    MyText.Text = Locator.Main.Result;
                }
            };

            MyButton.TouchUpInside += async (s, e) =>
            {
                await Locator.Main.Refresh();
            };

#if DEBUG
            MyText.Text = Locator.Main.Result;
#endif
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}