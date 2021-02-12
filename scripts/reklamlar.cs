using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class reklamlar : MonoBehaviour, IUnityAdsListener
{
    string gameId = "3815761";
    bool testMode = false;
    string myPlacementId = "rewardedVideo";
    string interstetialId = "video";
    private int para;
    //public GameObject acik10x;
    //public GameObject kapali10x;
    public bool reklamoynadi = false;
    public GameObject arti200;
    bool butonbasildi = false;
    bool skip = false;
    public GameObject levelkomplet;



    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.AddListener(this);
    }

    public void ShowInterstitialAd()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(interstetialId))
        {
            Advertisement.Show(interstetialId);
        }
        
    }
    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
            butonbasildi = true;
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }
    public void ShowRewardedVideoskip()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
            skip = true;
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            if (butonbasildi == true)
            {
                para = PlayerPrefs.GetInt("parag");
                para = para + 180;
                PlayerPrefs.SetInt("parag", para);
                reklamoynadi = true;
                arti200.SetActive(true);
            }
            if (skip == true) { levelkomplet.SetActive(true); }
           
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
           // Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            //kapali10x.SetActive(false);
            //acik10x.SetActive(true);
            PlayerPrefs.SetInt("reklamci",1);
        }
    }

    void Update()
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
        
    }
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}
