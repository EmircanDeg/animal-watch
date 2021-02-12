using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class onoffkaymaKaze : MonoBehaviour
{
    public GameObject onoff;
    public int opened;
    // Start is called before the first frame update
    void Start()
    {
        opened = PlayerPrefs.GetInt("onoffhali");
        if(opened==0){
            opened=1;
        }else if(opened == 1){
            if(onoff != null){
                Animator animatorc = onoff.GetComponent<Animator>();
                animatorc.SetBool("onoffk", false);
                AudioListener.volume = 1f;
            }
        }else if(opened==2){
            if(onoff != null){
                Animator animatorc = onoff.GetComponent<Animator>();
                animatorc.SetBool("onoffk", true);
                AudioListener.volume = 0f;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kaymaPress(){
        if(onoff != null){
            Animator animatorc = onoff.GetComponent<Animator>();
            if(animatorc != null){
                bool Openeddd = animatorc.GetBool("onoffk");           
                animatorc.SetBool("onoffk", !Openeddd);
                if(Openeddd==true){
                    PlayerPrefs.SetInt("onoffhali",1);
                    AudioListener.volume = 1f;
                }else if(Openeddd==false){
                    PlayerPrefs.SetInt("onoffhali",2);
                    AudioListener.volume = 0f;
                }
            }
        }
    }
}
