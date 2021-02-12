using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paraduzucu : MonoBehaviour
{
    public int para;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("parag",0);
        
    }

    public void ikramiye(){
        para = PlayerPrefs.GetInt("parag");
        para = para + 900;
        PlayerPrefs.SetInt("parag",para);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
