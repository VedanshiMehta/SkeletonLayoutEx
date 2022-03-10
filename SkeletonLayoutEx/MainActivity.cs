using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Supercharge;

namespace SkeletonLayoutEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ShimmerLayout shimmerLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            shimmerLayout = FindViewById<ShimmerLayout>(Resource.Id.shimmerLayout);
            //shimmerLayout.SetShimmerAnimationDuration(1000);
            shimmerLayout.StartShimmerAnimation();


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}