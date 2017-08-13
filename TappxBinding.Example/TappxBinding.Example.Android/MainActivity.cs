using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Tappx.Sdk.Android;

namespace TappxBinding.Example.Droid
{
	[Activity (Label = "TappxBinding.Example.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            
			SetContentView (Resource.Layout.Main);

            CreateBanner();
        }

        private void CreateBanner()
        {
            // Here we are creating a new banner ad, adding it to the layout and loading a new ad
            // Ad is using a key (Resource.String.tappx_key) which is connected to the app - CHANGE THAT KEY IN YOUR APP
            // To generate your own key you have to create an account on Tappx website and create a new app there: http://www.tappx.com
            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.myLayout);
            var tappxAd = new TappxBanner(this, Resources.GetString(Resource.String.tappx_key));
            var lp = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
            lp.Gravity = GravityFlags.Center;
            tappxAd.LayoutParameters = lp;
            tappxAd.SetListener(new MyTappxBannerListener());
            tappxAd.SetAdSize(TappxBanner.AdSize.BANNER320x50);
            layout.AddView(tappxAd);
            var request = new AdRequest()
#if DEBUG
                .UseTestAds(true)
#endif
                ;
            tappxAd.LoadAd(request);
        }
    }

    public class MyTappxBannerListener : Java.Lang.Object, ITappxBannerListener
    {
        public void OnBannerClicked(TappxBanner p0)
        {
            System.Diagnostics.Debug.WriteLine("[TappxBanner] OnBannerClicked");
        }

        public void OnBannerCollapsed(TappxBanner p0)
        {
            System.Diagnostics.Debug.WriteLine("[TappxBanner] OnBannerCollapsed");
        }

        public void OnBannerExpanded(TappxBanner p0)
        {
            System.Diagnostics.Debug.WriteLine("[TappxBanner] OnBannerExpanded");
        }

        public void OnBannerLoaded(TappxBanner p0)
        {
            System.Diagnostics.Debug.WriteLine("[TappxBanner] OnBannerLoaded");
        }

        public void OnBannerLoadFailed(TappxBanner p0, TappxAdError p1)
        {
            System.Diagnostics.Debug.WriteLine("[TappxBanner] OnBannerLoadFailed: " + p1.ToString());
        }
    }
}


