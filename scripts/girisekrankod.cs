using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class girisekrankod : MonoBehaviour
{
    public int level;
    public int sayac;
    float zaman = 0;
    public float frame;
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("kalinanlevel");
        if(level==0){
            level=1;
        }
        PlayerPrefs.SetInt("reklamci",0);
        StartCoroutine(ExampleCoroutine());
        
    }

    IEnumerator ExampleCoroutine(){
        yield return new WaitForSeconds(4.8f);
        SceneManager.LoadScene("level"+level);
        //SceneManager.LoadScene("capraz");
    }

    public void levelNext() { SceneManager.LoadScene("level" + level); }
    void Update()
    {
        /*zaman = zaman + Time.deltaTime;
        if (zaman >= frame) { sayac--;zaman = 0; }
        if(sayac == 0) { SceneManager.LoadScene("level" + level); }*/
    }
}
