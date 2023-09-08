using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1;
using App1.Droid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(AdMobView),typeof(AdMobViewRenderer))]
namespace App1.Droid
{
    public class AdMobViewRenderer : ViewRenderer<AdMobView, AdView>
    {
        public AdMobViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var adView = new AdView(Context)
                {
                    AdUnitId = "ca-app-pub-2165341686632098/1176174976",
                    AdSize = AdSize.Banner,
                    
                };
                adView.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
                AdRequest.Builder adRequest = new AdRequest.Builder();
                adView.LoadAd(adRequest.Build());
                SetNativeControl(adView);
            }
        }
    }
}