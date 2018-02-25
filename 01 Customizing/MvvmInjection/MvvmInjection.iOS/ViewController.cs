using GalaSoft.MvvmLight.Helpers;
using System;
using System.Collections.Generic;
using UIKit;

namespace MvvmInjection.iOS
{
    public partial class ViewController : UIViewController
    {
        private List<Binding> _bindings = new List<Binding>();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _bindings.Add(this.SetBinding(
                () => Application.Locator.Main.Result,
                () => MyText.Text));

            MyButton.SetCommand(Application.Locator.Main.RefreshCommand);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}