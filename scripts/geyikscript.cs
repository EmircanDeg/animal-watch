using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geyikscript : MonoBehaviour
{
    private Animator anim;
    private int yemeksayac = 0;
    public AudioSource ses;
    public AudioSource sesciyak;
    public AudioSource yemekses;
    public float ynokta = 4.5f;
    private bool olme = false;
    private bool havuctoplandi = false;
    private bool inikmi = false;
    private bool sesleme = false;
    public float olmeysi = 50;
    

    public GameObject menuKomp;
    public GameObject failkayma;
    public GameObject[] konfetiler;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("hareket");
        gameObject.GetComponent<BoxCollider>().enabled = false;
        failkayma = GameObject.Find("Canvas/fail");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(olme == false) {
            if (inikmi == true) {
                if (collision.gameObject.tag == "yemek")
                {
                    yemeksayac++;
                    ses.Play();
                    if (yemeksayac > 9) { Invoke("havucyeme", 0.5f); }

                }
            }
            
        }
        if (havuctoplandi == false) {
            if (transform.position.y < olmeysi)
            {
                if (collision.gameObject.tag == "zehirli") { olme = true; gameObject.GetComponent<BoxCollider>().enabled = false; anim.Play("olme"); sesciyak.Play(); StartCoroutine(ExampleCoroutinez()); }
                if (collision.gameObject.tag == "ates") { olme = true; gameObject.GetComponent<BoxCollider>().enabled = false; anim.Play("olme"); sesciyak.Play(); StartCoroutine(ExampleCoroutinez()); }
                if (collision.gameObject.tag == "kazik") { olme = true; gameObject.GetComponent<BoxCollider>().enabled = false; anim.Play("olme"); sesciyak.Play(); StartCoroutine(ExampleCoroutinez()); }
            }
           
        }
        
    }

    IEnumerator ExampleCoroutinez(){
        yield return new WaitForSeconds(1);
        Animator animatorc = failkayma.GetComponent<Animator>();
        animatorc.SetBool("dusus", true);
    }

    void havucyeme() { 
        yemekses.Play();
        konfetiler = GameObject.FindGameObjectsWithTag("konfeti");
        foreach (GameObject konfetis in konfetiler){
            konfetis.transform.localScale = new Vector3(5, 5, 5);
        }
        StartCoroutine(ExampleCoroutine());
        
    }

    IEnumerator ExampleCoroutine(){
        yield return new WaitForSeconds(2.5f);
        menuKomp.SetActive(true);
    }

    void Update()
    {
        if(sesleme == false) { sesciyak.Play(); sesleme = true;}
        //Debug.Log("HAVUC TOPLANDI "+havuctoplandi);
        //Debug.Log(yemeksayac);
        if (olme == false) { if (yemeksayac > 9) { anim.Play("yemek"); havuctoplandi = true; } }
        
        if(yemeksayac == 10) 
            {
            havuctoplandi = true;
        }
        
        if(gameObject.transform.position.y < ynokta)
        {
            if (inikmi == false) { gameObject.GetComponent<BoxCollider>().enabled = true; inikmi = true; }
            
        }
        
    }
}
