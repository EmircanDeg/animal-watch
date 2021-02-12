using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;
using TMPro;

public class skinalmakodu : MonoBehaviour
{
    public string hayvanadi;
    public string yemekadi;
    public GameObject[] yemekx;
    public GameObject[] hayvansx;
    public GameObject[] hayvans;
    public GameObject[] hayvans2;
    public GameObject[] yemeks;
    public GameObject[] yemeks2;
    public GameObject[] hepsis1;
    public GameObject[] hepsis2;
    public int animalc;
    public int yemekc;
    public int para;
    public int para2;
    public int level;
    public string nextScene;
    public GameObject paragoster;
    public GameObject buykapali;
    public GameObject buybutonu;
    public GameObject arti125buton;
    public GameObject animeci;
    public GameObject animeci2;
    public GameObject secilen;
    public string secilenname;
    public int paracik;
    public GameObject donenisik;
    public GameObject konfetigif;
    public GameObject okbuton;
    public GameObject nothankskapa;
    public GameObject notenk;
    public AudioSource konfetises;
    public AudioSource alsikses;
    public GameObject soruisretitoken;
    // Start is called before the first frame update
    void Start()
    {
        Scene scenew = SceneManager.GetActiveScene();
        if(scenew.name == "levelkaze"){
            hayvancheck();
            int j = Random.Range(0,hepsis1.Length);
            secilenname = hepsis1[j].name;
            hayvanadi = secilenname;
        }else if(scenew.name == "levelkazeyemek"){
            yemekcheck();
            int k = Random.Range(0,hepsis2.Length);
            secilenname = hepsis2[k].name;
            yemekadi = secilenname;
        }
        hayvandeact();
        yemekdeact();
        level = PlayerPrefs.GetInt("sonrakilevel");
        nextScene = "level" + level;
        Array.Clear(hepsis1, 0, hepsis1.Length);
        Array.Clear(hepsis2, 0, hepsis2.Length); 
    }

    public void hayvansatinalmabutonu(){
        para2 = PlayerPrefs.GetInt("parag");
        para2 = para2 - 1000;
        PlayerPrefs.SetInt("parag",para2);
        PlayerPrefs.SetInt(hayvanadi,5);
        arti125buton.SetActive(false);
        buybutonu.SetActive(false);
        konfetigif.SetActive(true);
        okbuton.SetActive(true);
        notenk.SetActive(false);
        alsikses.Play();
        konfetises.Play();
    }

    public void yemeksatinalmabutonu(){
        para2 = PlayerPrefs.GetInt("parag");
        para2 = para2 - 1000;
        PlayerPrefs.SetInt("parag",para2);
        PlayerPrefs.SetInt(yemekadi,5);
        arti125buton.SetActive(false);
        buybutonu.SetActive(false);
        konfetigif.SetActive(true);
        okbuton.SetActive(true);
        notenk.SetActive(false);
        alsikses.Play();
        konfetises.Play();
    }

    public void yemekdeact(){
        yemekx = GameObject.FindGameObjectsWithTag("yemeks");
        for (int i=0; i<yemekx.Length; i++){
            string adi = yemekx[i].name;
            if(adi!=yemekadi){
                yemekx[i].SetActive(false);
            }
        }
    }

    public void hayvandeact(){
        hayvansx = GameObject.FindGameObjectsWithTag("hayvan");
        for (int i=0; i<hayvansx.Length; i++){
            string adi = hayvansx[i].name;
            if(adi!=hayvanadi){
                hayvansx[i].SetActive(false);
            }
        }
    }

    public void hayvancheck(){
        hayvans = GameObject.FindGameObjectsWithTag("hayvan");
        foreach (GameObject hayvan in hayvans){
            if(hayvan.name=="ayi_genel"){
                if(PlayerPrefs.GetInt("ayi_genel")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvan[i].name;
                }
            }else if(hayvan.name=="kopek_acıkkahve"){
                if(PlayerPrefs.GetInt("kopek_acıkkahve")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvans[i].name;
                }
            }else if(hayvan.name=="kedigri"){
                if(PlayerPrefs.GetInt("kedigri")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvans[i].name;
                }
            }else if(hayvan.name=="kedikahve"){
                if(PlayerPrefs.GetInt("kedikahve")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvans[i].name;
                }
            }else if(hayvan.name=="kopek_kahve"){
                if(PlayerPrefs.GetInt("kopek_kahve")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvans[i].name;
                }
            }else if(hayvan.name=="kutupayi"){
                if(PlayerPrefs.GetInt("kutupayi")==0){
                    Array.Resize(ref hepsis1, hepsis1.Length+1);
                    hepsis1[hepsis1.Length-1] = hayvan;
                    //hepsis1[i]=hayvans[i].name;
                }
            }
        }
    }

    public void leveldegis(){
        SceneManager.LoadScene(nextScene);
    }

    public void yemekcheck(){
        yemeks = GameObject.FindGameObjectsWithTag("yemeks");
        foreach (GameObject yemek in yemeks){
            if(yemek.name=="muzlar"){
                if(PlayerPrefs.GetInt("muzlar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="patates"){
                if(PlayerPrefs.GetInt("patates")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="pizaalar"){
                if(PlayerPrefs.GetInt("pizaalar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="peynirs"){
                if(PlayerPrefs.GetInt("peynirs")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="tavukbutlar"){
                if(PlayerPrefs.GetInt("tavukbutlar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="dondurmalar"){
                if(PlayerPrefs.GetInt("dondurmalar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="hamburgers"){
                if(PlayerPrefs.GetInt("hamburgers")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="hotdoglar"){
                if(PlayerPrefs.GetInt("hotdoglar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="dondurmakulahlar"){
                if(PlayerPrefs.GetInt("dondurmakulahlar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="kirazlar"){
                if(PlayerPrefs.GetInt("kirazlar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="cikolalidonut"){
                if(PlayerPrefs.GetInt("cikolalidonut")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="karpuzlar"){
                if(PlayerPrefs.GetInt("karpuzlar")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="cilkelidonut"){
                if(PlayerPrefs.GetInt("cilkelidonut")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }else if(yemek.name=="portiler"){
                if(PlayerPrefs.GetInt("portiler")==0){
                    Array.Resize(ref hepsis2, hepsis2.Length+1);
                    hepsis2[hepsis2.Length-1] = yemek;
                    //hepsis2[i]=yemeks[i];
                }
            }
        }
    }

    public void satinalmahayvan(){
        para2 = PlayerPrefs.GetInt("parag");
        para2 = para2 - 1000;
        PlayerPrefs.SetInt("parag",para2);
        int j = Random.Range(0,hepsis1.Length);
        PlayerPrefs.SetInt(hepsis1[j].name,5);
        arti125buton.SetActive(false);
        buybutonu.SetActive(false);
        secilenname = hepsis1[j].name;
        hayvans2 = GameObject.FindGameObjectsWithTag("buyumetoken");
        foreach (GameObject hayvan in hayvans2){
            if(hayvan.name!=secilenname){
                secilen = GameObject.Find("Canvas/animaltokens/"+hayvan.name);
                secilen.SetActive(false);
            }
        }
        Animator animatorc = animeci.GetComponent<Animator>();
        animatorc.SetBool("buyume", true);
        donenisik.SetActive(true);
        konfetigif.SetActive(true);
        okbuton.SetActive(true);
        soruisretitoken.SetActive(false);
        nothankskapa.SetActive(true);
        notenk.SetActive(false);
        alsikses.Play();
        konfetises.Play();
        Debug.Log(hepsis1[j]);
    }
    public void satinalmayemek(){
        para2 = PlayerPrefs.GetInt("parag");
        para2 = para2 - 1000;
        PlayerPrefs.SetInt("parag",para2);
        int k = Random.Range(0,hepsis2.Length);
        PlayerPrefs.SetInt(hepsis2[k].name,5);
        secilenname = hepsis2[k].name;
        arti125buton.SetActive(false);
        buybutonu.SetActive(false);
        yemeks2 = GameObject.FindGameObjectsWithTag("buyumetoken");
        foreach (GameObject yemek in yemeks2){
            if(yemek.name!=secilenname){
                secilen = GameObject.Find("Canvas/yemelikler/"+yemek.name);
                secilen.SetActive(false);
            }
        }
        Animator animatorz = animeci2.GetComponent<Animator>();
        animatorz.SetBool("buyume", true);
        donenisik.SetActive(true);
        konfetigif.SetActive(true);
        soruisretitoken.SetActive(false);
        okbuton.SetActive(true);
        nothankskapa.SetActive(true);
        notenk.SetActive(false);
        alsikses.Play();
        konfetises.Play();
        Debug.Log(hepsis2[k]);
    }

    // Update is called once per frame
    void Update()
    {
        paracik = PlayerPrefs.GetInt("parag");
        Text txtc = GameObject.Find ("Canvas/skinalma/Text").GetComponent<Text>();
        txtc.text = paracik.ToString();
        para = PlayerPrefs.GetInt("parag");
        if(para>999){
            buykapali.SetActive(false);
        }
        
    }
}
