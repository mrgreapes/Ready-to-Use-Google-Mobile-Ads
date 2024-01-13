using UnityEngine;
using GoogleMobileAds.Common;
using GoogleMobileAds.Api;
using System.Data.Common;

public class AdsService : MonoBehaviour
{
    [Header("Enable Ads")]
    public bool _showInterstitial = false;
    public bool _showBanner = false;
    public bool _showRewardedAd = false;
    public bool _showAppOpenAd = false;
    public bool _showRewardedInterstitial = false;

    [Header("Android Unit Ids")]
    public string interstitialUnitId = "ca-app-pub-3940256099942544/1033173712";
    public string bannerUnitId = "ca-app-pub-3940256099942544/6300978111";
    public string rewardedUnitId = "ca-app-pub-3940256099942544/5224354917";
    public string rewardedInterstitialUnitId = "ca-app-pub-3940256099942544/5354046379";
    public string appOpenAdUnitId = "ca-app-pub-3940256099942544/9257395921";

    [Header("IOS Unit Ids")]
    public string interstitalUnitIdIOS = "ca-app-pub-3940256099942544/4411468910";
    public string bannerUnitIdIOS = "ca-app-pub-3940256099942544/2934735716";
    public string rewardedUnitIdIOS = "ca-app-pub-3940256099942544/1712485313";
    public string rewardedInterstitialUnitIdIOS = "ca-app-pub-3940256099942544/6978759866";
    public string appOpenAdUnitIdIOS = "ca-app-pub-3940256099942544/5575463023";

    // [Header("Banner Settings")]
    // public bool _bannerBottom = false;
    // public bool _bannerTop = true;

    [Header("Ads Scripts References")]
    [SerializeField]
    private BannerViewController _bannerViewController;
    [SerializeField]
    private InterstitialAdController _interstitialAdController;
    [SerializeField]
    private RewardedAdController _rewardedAdController;
    [SerializeField]
    private RewardedInterstitialAdController _rewardedInterstitialAdController;
    [SerializeField]
    private AppOpenAdController _appOpenAdController;
    [SerializeField]
    private GoogleMobileAdsController _googleMobileAdsController;
    [SerializeField]
    private GoogleMobileAdsConsentController _googleMobileAdsConsentController;

    private void Awake()
    {
        InitializeAdUnitIds();

        if (_showAppOpenAd)
            _appOpenAdController.LoadAd();

        AppStateEventNotifier.AppStateChanged += OnAppStateChanged;
    }
    public void InitializeAdUnitIds()
    {
#if UNITY_ANDROID
        _bannerViewController.AdUnitId = bannerUnitId;
        _rewardedAdController.AdUnitId = rewardedUnitId;
        _interstitialAdController.AdUnitId = interstitialUnitId;
        _rewardedInterstitialAdController.AdUnitId = rewardedInterstitialUnitId;
        _appOpenAdController.AdUnitId = appOpenAdUnitId;

#elif UNITY_IPHONE
        _bannerViewController.AdUnitId = bannerUnitIdIOS;
        _rewardedAdController.AdUnitId = rewardedUnitIdIOS;
        _interstitialAdController.AdUnitId = interstitalUnitIdIOS;
        _rewardedInterstitialAdController.AdUnitId = rewardedInterstitialUnitIdIOS;
        _appOpenAdController.AdUnitId = appOpenAdUnitIdIOS;
#else
        _bannerViewController.AdUnitId = "unused";
        _rewardedAdController.AdUnitId = "unused";
        _interstitialAdController.AdUnitId = "unused";
        _rewardedInterstitialAdController.AdUnitId = "unused";
        _appOpenAdController.AdUnitId = "unused";
#endif
    }

    public InterstitialAdController InterstitialAdController()
    {
        return _interstitialAdController;
    }
    public BannerViewController BannerViewController()
    {
        return _bannerViewController;
    }

    public RewardedAdController RewardedAdController()
    {
        return _rewardedAdController;
    }

    public RewardedInterstitialAdController RewardedInterstitialAdController()
    {
        return _rewardedInterstitialAdController;
    }

    public AppOpenAdController AppOpenAdController()
    {
        return _appOpenAdController;
    }

    public GoogleMobileAdsController GoogleMobileAdsController()
    {
        return _googleMobileAdsController;
    }

    public GoogleMobileAdsConsentController GoogleMobileAdsConsentController()
    {
        return _googleMobileAdsConsentController;
    }


    public void ShowInterstitailAd()
    {
        if (_showInterstitial)
            _interstitialAdController.ShowAd();
    }

    public void ShowBannerAd()
    {
        if (_showBanner)
            _bannerViewController.ShowAd();
    }

    public void HideBannerAd()
    {
        _bannerViewController.HideAd();
    }
    public void ShowRewardedAd()
    {
        if (_showRewardedAd)
            _rewardedAdController.ShowAd();
    }

    public void ShowRewardedInterstitial()
    {
        if (_showRewardedInterstitial)
            _rewardedInterstitialAdController.ShowAd();
    }

    private void OnAppStateChanged(AppState state)
    {
        Debug.Log("App State changed to : " + state);

        // If the app is Foregrounded and the ad is available, show it.
        if (state == AppState.Foreground)
        {
            if (_showAppOpenAd)
                _appOpenAdController.ShowAd();
        }
    }
}
