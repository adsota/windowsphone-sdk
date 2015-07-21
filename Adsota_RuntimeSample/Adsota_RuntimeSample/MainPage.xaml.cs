using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Adsota_RuntimeSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int banner_AdUnitID = 0;
        int fullscreen_AdUnitID = 0;
        int offerwall_AdUnitID = 0;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnBanner_Tapped(object sender, TappedRoutedEventArgs e)
        {
            banner.LoadAd(banner_AdUnitID);
        }

        private void btnScreen_Tapped(object sender, TappedRoutedEventArgs e)
        {
            fullscreen.LoadAd(fullscreen_AdUnitID);
        }

        private void btnOfferWall_Tapped(object sender, TappedRoutedEventArgs e)
        {
            OfferWall.LoadAd(offerwall_AdUnitID);
        }
    }
}
