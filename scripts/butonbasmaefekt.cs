using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class butonbasmaefekt : MonoBehaviour
{
    public GameObject image;
    public GameObject imageS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausepress(){
        imageS = GameObject.Find ("Canvas/Pause/Image");
        Animator animatorc = imageS.GetComponent<Animator>();
        animatorc.SetBool("sttg", true);
    }

    public void pauseup(){
        imageS = GameObject.Find ("Canvas/Pause/Image");
        Animator animatorc = imageS.GetComponent<Animator>();
        animatorc.SetBool("sttg", false);
    }

    public void replayup(){
        image = GameObject.Find ("Canvas/replay/Image");
        Animator animatorc = image.GetComponent<Animator>();
        animatorc.SetBool("rp", false);
    }

    public void replaypress(){
        image = GameObject.Find ("Canvas/replay/Image");
        Animator animatorc = image.GetComponent<Animator>();
        animatorc.SetBool("rp", true);
    }
}
