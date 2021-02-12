using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class reklam125 : MonoBehaviour ,IUnityAdsListener
{
    string gameId = "3815761";
    bool testMode = true;
    string myPlacementId = "rewardedVideo2";
    //public GameObject acik;
    //public GameObject kapali;
    private int para;
    


    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.AddListener(this);
    }

    
    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);

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
            para = PlayerPrefs.GetInt("parag");
            para = para + 125;
            PlayerPrefs.SetInt("parag", para);
            
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
            //kapali.SetActive(false);
            //acik.SetActive(true);
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
