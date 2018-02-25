using Android.App;
using Android.Widget;
using Android.OS;

namespace UsingRelativeLayout
{
    [Activity(
        Label = "UsingRelativeLayout", 
        MainLauncher = true, 
        Icon = "@drawable/icon",
        ConfigurationChanges=Android.Content.PM.ConfigChanges.Orientation 
            | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class MainActivity : Activity
    {
        private EditText _myText;
        private TextView _myLabel;

        private RelativeLayout.LayoutParams _portraitParameters;
        private RelativeLayout.LayoutParams _landscapeParameters;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _myLabel = FindViewById<TextView>(Resource.Id.FirstNameLabel);
            _myText = FindViewById<EditText>(Resource.Id.FirstNameBox);

            _landscapeParameters = new RelativeLayout.LayoutParams(
                _myText.LayoutParameters);
            _landscapeParameters.LeftMargin = 15;
            _landscapeParameters.RightMargin = 15;

            _landscapeParameters.AddRule(
                LayoutRules.RightOf, 
                _myLabel.Id);

            _portraitParameters = new RelativeLayout.LayoutParams(
                _myText.LayoutParameters);
            _portraitParameters.LeftMargin = 15;
            _portraitParameters.RightMargin = 15;

            _portraitParameters.AddRule(
                LayoutRules.Below,
                _myLabel.Id);
        }

        public override void OnConfigurationChanged(
            Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            if (newConfig.Orientation == Android.Content.Res.Orientation.Portrait)
            {
                _myText.LayoutParameters = _portraitParameters;
            }
            else if (newConfig.Orientation == Android.Content.Res.Orientation.Landscape)
            {
                _myText.LayoutParameters = _landscapeParameters;
            }
        }
    }
}

