using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yemeksilinik : MonoBehaviour
{
    public GameObject buton;
    private GameObject panelvan;
    private Vector3 konum1;
    private Vector3 konum2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        panelvan = GameObject.Find("Canvas/yemelikler/yemekskinleri");
        konum1 = panelvan.transform.position;
        
    }

    IEnumerator ExampleCoroutine(){
        Animator animatorc = buton.GetComponent<Animator>();
        animatorc.SetBool("yemekgor", true);
        yield return new WaitForSeconds(1.5f);
        animatorc.SetBool("yemekgor", false);
    }

    IEnumerator ExampleCoroutine2(){
        yield return new WaitForSeconds(1.5f);
        Animator animatorcz = buton.GetComponent<Animator>();
        if(konum1==konum2){
            animatorcz.SetBool("yemekgor", false);
        }else{
            animatorcz.SetBool("yemekgor", true);
        }
    }

    public void basma(){
        Animator animatorc = buton.GetComponent<Animator>();
        bool Opene = animatorc.GetBool("yemekgor");
        animatorc.SetBool("yemekgor", !Opene);
        bool Opene2 = animatorc.GetBool("yemekgor");
    }

    // Update is called once per frame
    void Update()
    {
        konum2 = panelvan.transform.position;
        StartCoroutine(ExampleCoroutine2());
        
    }
}
