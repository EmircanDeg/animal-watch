using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sesMenuKod : MonoBehaviour
{
    public GameObject SesMor;
    public GameObject sesci1;
    public int xx = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        

    }
    public void sesPress(){
        xx = PlayerPrefs.GetInt("secim", 1);
        //sesci2.SetActive(true);
        gameObject.SetActive(false);

    }
}
