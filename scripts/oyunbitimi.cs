using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunbitimi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void newgame(){
        PlayerPrefs.SetInt("newgamep",6);
        SceneManager.LoadScene("level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
