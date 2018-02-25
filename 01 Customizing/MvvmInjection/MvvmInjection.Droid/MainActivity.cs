using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;

namespace MvvmInjection.Droid
{
    [Activity(Label = "MvvmInjection.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Binding> _bindings = new List<Binding>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _bindings.Add(this.SetBinding(
                () => App.Locator.Main.Result,
                () => ResultText.Text));

            MyButton.SetCommand(App.Locator.Main.RefreshCommand);
        }

        #region UI Elements

        private Button _myButton;

        public Button MyButton
        {
            get
            {
                return _myButton
                       ?? (_myButton = FindViewById<Button>(Resource.Id.MyButton));
            }
        }

        private TextView _resultText;

        public TextView ResultText
        {
            get
            {
                return _resultText
                       ?? (_resultText = FindViewById<TextView>(Resource.Id.ResultText));
            }
        }

        #endregion
    }
}

