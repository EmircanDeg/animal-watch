using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class levelComplete : MonoBehaviour
{
    Scene m_Scene;
    public string currentScene;
    public string nextScene;
    public int para;
    public int level;
    public GameObject skinci;
    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        currentScene = m_Scene.name;
        string sayi1 = Regex.Match(currentScene, @"\d+").Value;
        int sayi2 = int.Parse(sayi1);
        sayi2 = sayi2 + 1;
        level = sayi2;
        nextScene = "level" + sayi2;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void paracik(){
        para = PlayerPrefs.GetInt("parag");
        para = para + 20;
        PlayerPrefs.SetInt("parag",para);
    }

    /*public void skinKazan(){
        skinci = GameObject.Find("Canvas/newSkinci");
        Animator animatorc = skinci.GetComponent<Animator>();
        animatorc.SetBool("dusus", true);
    }*/

    public void nextLevel(){
        paracik();
        if(PlayerPrefs.GetInt("newgamep")==6){
            SceneManager.LoadScene(nextScene);
        }else{
            if(currentScene=="level2" || currentScene=="level17" || currentScene=="level32" || currentScene=="level47" || currentScene=="level62" || currentScene=="level87"){
                PlayerPrefs.SetInt("sonrakilevel",level);
                SceneManager.LoadScene("levelkaze");
            }else if(currentScene=="level7" || currentScene=="level12" || currentScene=="level22" || currentScene=="level27" || currentScene=="level37" || currentScene=="level42" || currentScene=="level52" || currentScene=="level57" || currentScene=="level67" || currentScene=="level72" || currentScene=="level77" || currentScene=="level82" || currentScene=="level92" || currentScene=="level97"){
                PlayerPrefs.SetInt("sonrakilevel",level);
                SceneManager.LoadScene("levelkazeyemek");
            }else{
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
