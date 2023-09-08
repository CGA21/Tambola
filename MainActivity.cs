using Android.Gms.Ads;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace App1.Droid
{
    [Activity(Label = "Tambola!!", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

//          Used for Testing Ads. Disable before Main Upload
/*            RequestConfiguration.Builder builder = new RequestConfiguration.Builder();
            builder = builder.SetTestDeviceIds(new string[] { "9FAE4AB68FB1BB65C7ED6DA68447147F" });
            MobileAds.RequestConfiguration = builder.Build();
*/
            MobileAds.Initialize(ApplicationContext);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}