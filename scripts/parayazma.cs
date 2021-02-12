using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parayazma : MonoBehaviour
{
    
    GameObject kapalibuy;
    GameObject paratext;
    void Start()
    {
        paratext = GameObject.Find("paratext");
        kapalibuy = GameObject.Find("kapalibuy");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("parag") > 999) { Destroy(kapalibuy); }
        paratext.GetComponent<Text>().text = PlayerPrefs.GetInt("parag").ToString();
    }
}
