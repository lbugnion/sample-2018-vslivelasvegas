using Android.App;
using Android.Widget;
using Android.OS;
using SimpleInjectionData.ViewModel;

namespace SimpleInjection.Droid
{
    [Activity(Label = "SimpleInjection.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ViewModelLocator _locator;

        public ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Locator.Main.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(MainViewModel.Result))
                {
                    ResultText.Text = Locator.Main.Result;
                }
            };

            MyButton.Click += async (s, e) =>
            {
                await Locator.Main.Refresh();
            };

#if DEBUG
            ResultText.Text = Locator.Main.Result;
#endif
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

