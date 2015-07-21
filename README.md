#  Appota Windows Phone Ads SDK for Publisher

[1. Import Appota Ads SDK](#1-import-appota-ads-sdk)

[2. Set up Appota Ads SDK](#2-set-up-appota-ads-sdk)

[2.1. Configure SDK](#21configure-sdk)

[2.2. Load ads](#22-load-ads)

## [1. Import Appota Ads SDK]()

Run the following command in the Package Manager Console
   - Windows Phone 8.0 Silverlight : right click your project, click Retarget to Windows Phone 8.1 first and run the following command   **Install-Package AdsotaSL**
   - Windows Phone 8.1 Silverlight : **Install-Package AdsotaSL**
   - Windows Phone 8.1 Runtime : **Install-Package Adsota**

## [2. Set up Appota Ads SDK]()

## [2.1. Configure SDK]()

### Configure in AppotaConfig.xml
		
		<!--Replace placeholder apiKey with your apiKey in https://developer.appota.com/-->
        <apiKey>K-A173418-U00000-IOFEUF-09603AB8EC80BD17</apiKey>
        
## [2.2. Load Ad]()

- Declare namespace in xaml
  - Windows Phone 8.1 Silverlight : xmlns:Adsota="clr-namespace:AppotaAdsSL;assembly=AppotaAdsSL"
  - Windows Phone 8.1 Runtime : xmlns:Adsota="using:AppotaAds"
		
- Declare control in xaml
  - Banner : <Adsota:Banner Name="banner" VerticalAlignment="Bottom"/>
  - Full Screen (Interstitial) : <Adsota:FullScreen Name="fullscreen"/>
  - OfferWall : <Adsota:OfferWall Name="OfferWall"/>

- In code : 
  - Banner : 

             banner.LoadAd(int AdUnitId);
             banner.LoadAds_Complete += banner_LoadAds_Complete;

             void banner_LoadAds_Complete(object sender, string message)
             {
              // your code here
             }

  - Full Screen : 

             fullscreen.LoadAd(int AdUnitId);
             fullscreen.LoadAds_Complete += fullscreen_LoadAds_Complete;
             fullscreen.CloseAds_Complete += fullscreen_CloseAds_Complete;

             void fullscreen_LoadAds_Complete(object sender, string message)
             {
              // your code here
             }

             void fullscreen_CloseAds_Complete(object sender, string message)
             {
              // your code here
             }

  - Offer Wall : 

             OfferWall.LoadAd(int AdUnitId);
             OfferWall.LoadAds_Complete += OfferWall_LoadAds_Complete;
             OfferWall.CloseAds_Complete += OfferWall_CloseAds_Complete;

             void OfferWall_LoadAds_Complete(object sender, string message)
             {
              // your code here
             }

             void OfferWall_CloseAds_Complete(object sender, string message)
             {
              // your code here
             }

