using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Adsota_SilverlightSample.Resources;

namespace Adsota_SilverlightSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        int banner_AdUnitID = 0;
        int fullscreen_AdUnitID = 0;
        int offerwall_AdUnitID = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            banner.LoadAds_Complete += banner_LoadAds_Complete;
            fullscreen.LoadAds_Complete += fullscreen_LoadAds_Complete;
            fullscreen.CloseAds_Complete += fullscreen_CloseAds_Complete;
            OfferWall.CloseAds_Complete += OfferWall_CloseAds_Complete;
            OfferWall.LoadAds_Complete += OfferWall_LoadAds_Complete;
        }

        void banner_LoadAds_Complete(object sender, string message)
        {

        }

        void fullscreen_CloseAds_Complete(object sender, string message)
        {

        }

        void fullscreen_LoadAds_Complete(object sender, string message)
        {

        }

        void OfferWall_LoadAds_Complete(object sender, string message)
        {

        }

        void OfferWall_CloseAds_Complete(object sender, string message)
        {

        }

        private void btnBanner_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            banner.LoadAd(banner_AdUnitID);
        }

        private void btnScreen_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            fullscreen.LoadAd(fullscreen_AdUnitID);
        }

        private void btnOfferWall_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            OfferWall.LoadAd(offerwall_AdUnitID);
        }
    }
}