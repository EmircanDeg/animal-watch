using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapali10xsilme : MonoBehaviour
{
    int a;
    public GameObject acik10x;
    //GameObject kapalibuy;
    //int para;
    void Start()
    {
        //kapalibuy = GameObject.Find("kapalibuy");
    }

    // Update is called once per frame
    void Update()
    {
        //para = PlayerPrefs.GetInt("parag");
        //if (para > 999) { Destroy(kapalibuy); }
        a = PlayerPrefs.GetInt("reklamci");
        if (a == 1)
        {
            acik10x.SetActive(true);
            Destroy(gameObject);
        }
    }
}
