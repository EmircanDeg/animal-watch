using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesMenuKod2 : MonoBehaviour
{
    public GameObject sesci1;
    public int xx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sesPress2()
    {
        xx = PlayerPrefs.GetInt("secim", 0);
        sesci1.SetActive(true);
        gameObject.SetActive(false);
    }
}
