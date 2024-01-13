using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsCaller : MonoBehaviour
{
    [SerializeField]
    private AdsService adsService;

    public void ShowBanner(){
        adsService.ShowBannerAd();;
    }

    public void HideBanner(){
        adsService.HideBannerAd();
    }
    public void ShowInterstitial(){
        adsService.ShowInterstitailAd();
    }
    public void ShowRewardedAd(){
        adsService.ShowRewardedAd();
    }
    public void ShowRewardedInterstitial(){
        adsService.ShowRewardedInterstitial();
    }
}
