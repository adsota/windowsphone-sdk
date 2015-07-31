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

            banner.OnAdReceived += banner_OnAdReceived;
            banner.OnFailedToReceiveAd += banner_OnFailedToReceiveAd;
            fullscreen.OnAdClosed += fullscreen_OnAdClosed;
            fullscreen.OnAdReceived += fullscreen_OnAdReceived;
            fullscreen.OnFailedToReceiveAd += fullscreen_OnFailedToReceiveAd;
            OfferWall.OnAdClosed += OfferWall_OnAdClosed;
            OfferWall.OnAdReceived += OfferWall_OnAdReceived;
            OfferWall.OnFailedToReceiveAd += OfferWall_OnFailedToReceiveAd;
        }

        void OfferWall_OnFailedToReceiveAd(object sender, string message)
        {
            
        }

        void OfferWall_OnAdReceived(object sender, string message)
        {
            
        }

        void OfferWall_OnAdClosed(object sender, string message)
        {
            
        }

        void fullscreen_OnFailedToReceiveAd(object sender, string message)
        {
            
        }

        void fullscreen_OnAdReceived(object sender, string message)
        {
            
        }

        void fullscreen_OnAdClosed(object sender, string message)
        {
            
        }

        void banner_OnFailedToReceiveAd(object sender, string message)
        {
            
        }

        void banner_OnAdReceived(object sender, string message)
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