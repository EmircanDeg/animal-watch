using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class pausebutonKodu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Creditto;
    public GameObject Sescix;
    public GameObject reklamci;
    public GameObject skinci;
    public GameObject yskinci;

    Scene m_Scene;
    public string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        currentScene = m_Scene.name;
        string sayi1 = Regex.Match(currentScene, @"\d+").Value;
        int sayi2 = int.Parse(sayi1);
        PlayerPrefs.SetInt("kalinanlevel",sayi2);
        reklamci = GameObject.Find("REKLAMLAR");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void PausePress(){
        if(Panel != null){
            Animator animator = Panel.GetComponent<Animator>();
            if(animator != null){
                bool Openedd = animator.GetBool("menuOpen");
                animator.SetBool("menuOpen", !Openedd);
                bool Openedde = animator.GetBool("menuOpen");
                if(Openedde == false){
                    if(Creditto != null){
                        Animator animatorc = Creditto.GetComponent<Animator>();
                        if(animatorc != null){
                        animatorc.SetBool("creditOpen", false);
                    }
                }
                    if(Sescix != null){
                        Animator animatorx = Sescix.GetComponent<Animator>();
                        if(animatorx != null){
                        animatorx.SetBool("sesciOpen", false);
                }
                }
                }
            }
        }
    }

    public void skinokcu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReplayPress(){
        reklamci.GetComponent<reklamlar>().ShowInterstitialAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void creditPress(){
        if(Creditto != null){
            Animator animatorc = Creditto.GetComponent<Animator>();
            if(animatorc != null){
                bool Openeddd = animatorc.GetBool("creditOpen");
                animatorc.SetBool("creditOpen", !Openeddd);
            }
        }
    }

    public void skinPress(){
        if(skinci != null){
            Animator animatorz = skinci.GetComponent<Animator>();
            if(animatorz != null){
                bool Openz = animatorz.GetBool("skinOpen");
                animatorz.SetBool("skinOpen", !Openz);
            }
        }
    }

    public void yemekskinPress(){
        if(yskinci != null){
            Animator animatorzz = yskinci.GetComponent<Animator>();
            if(animatorzz != null){
                bool Openzz = animatorzz.GetBool("yemekSkin");
                animatorzz.SetBool("yemekSkin", !Openzz);
            }
            Animator animator2 = yskinci.GetComponent<Animator>();
            animator2.SetBool("yemesayfa", false);
        }
    }

    public void SesPress(){
        if(Sescix != null){
            Animator animatorx = Sescix.GetComponent<Animator>();
            if(animatorx != null){
                bool Openex = animatorx.GetBool("sesciOpen");
                animatorx.SetBool("sesciOpen", !Openex);
            }
        }
    }
}
