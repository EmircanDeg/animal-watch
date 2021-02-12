using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class failrepli : MonoBehaviour
{
    public GameObject reklamci;
    void Start()
    {
        reklamci = GameObject.Find("REKLAMLAR");
    }
    public void ReplayPress(){
        reklamci.GetComponent<reklamlar>().ShowInterstitialAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
