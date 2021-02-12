using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skinsilinik : MonoBehaviour
{
    public GameObject buton;
    private GameObject panelvan;
    private Vector3 konum1;
    private Vector3 konum2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        panelvan = GameObject.Find("Canvas/skinPanel");
        konum1 = panelvan.transform.position;
        
    }

    IEnumerator ExampleCoroutine(){
        Animator animatorc = buton.GetComponent<Animator>();
        animatorc.SetBool("gorunuk", true);
        yield return new WaitForSeconds(1.5f);
        animatorc.SetBool("gorunuk", false);
    }

    IEnumerator ExampleCoroutine2(){
        yield return new WaitForSeconds(1.5f);
        Animator animatorcz = buton.GetComponent<Animator>();
        if(konum1==konum2){
            animatorcz.SetBool("gorunuk", false);
        }else{
            animatorcz.SetBool("gorunuk", true);
        }
    }

    public void basma(){
        Animator animatorc = buton.GetComponent<Animator>();
        bool Opene = animatorc.GetBool("gorunuk");
        animatorc.SetBool("gorunuk", !Opene);
        bool Opene2 = animatorc.GetBool("gorunuk");
        if(Opene2==false){
        }
    }

    // Update is called once per frame
    void Update()
    {
        konum2 = panelvan.transform.position;
        StartCoroutine(ExampleCoroutine2());
        
    }
}
