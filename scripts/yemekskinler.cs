using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yemekskinler : MonoBehaviour
{
    public GameObject sayfaK;

    public GameObject[] tikler;
    public GameObject[] yemeks;
    private GameObject butonimage;
    private Image tikk;
    public int animalc;
    public GameObject animalOwn;
    public string hayvanadi;
    // Start is called before the first frame update
    void Start()
    {
        //sifirla();
        tiksilme();
        hayvandeact();
        karatoken();

        animalc = PlayerPrefs.GetInt("yemekler");
        if(animalc == 1 || animalc==0){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/havuclar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;

        }else if(animalc == 2){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/karpuzlar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 3){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/tavukbutlar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 4){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmalar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 5){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/portiler/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 6){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/peynirs/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 7){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/muzlar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 8){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/cikolalidonut/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 9){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmakulahlar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 10){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/cilkelidonut/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 11){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hamburgers/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 12){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hotdoglar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 13){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/patates/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 14){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/pizaalar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 15){
            butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/kirazlar/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }
        
    }

    public void tiksilme(){
        tikler = GameObject.FindGameObjectsWithTag("yemekTik");
        foreach (GameObject tikz in tikler){
            tikk = tikz.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 0f;
            tikk.color = tempColor;
        }
    }

    public void karatoken(){
        if(PlayerPrefs.GetInt("karpuzlar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/karpuzlark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("tavukbutlar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/tavukbutlark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("dondurmalar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmalark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("portiler")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/portilerk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("peynirs")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/peynirsk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("muzlar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/muzlark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("cikolalidonut")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/cikolalidonutk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("dondurmakulahlar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmakulahlark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("cilkelidonut")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/cilkelidonutk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("hamburgers")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hamburgersk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("hotdoglar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hotdoglark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("patates")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/patatesk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("pizaalar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/pizaalark");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kirazlar")==5){
            animalOwn = GameObject.Find("Canvas/yemelikler/yemekskinleri2/kirazlark");
            animalOwn.SetActive(false);
        }
    }

    public void sifirla(){
        yemeks = GameObject.FindGameObjectsWithTag("yemeks");
        foreach(GameObject yemek in yemeks){
            PlayerPrefs.SetInt(yemek.name,0);
        }
    }

    public void hayvandeact(){
        animalc = PlayerPrefs.GetInt("yemekler");
        if(animalc==1 || animalc==0){
            hayvanadi="havuclar";
        }else if(animalc==2){
            hayvanadi="karpuzlar";
        }else if(animalc==3){
            hayvanadi="tavukbutlar";
        }else if(animalc==4){
            hayvanadi="dondurmalar";
        }else if(animalc==5){
            hayvanadi="portiler";
        }else if(animalc==6){
            hayvanadi="peynirs";
        }else if(animalc==7){
            hayvanadi="muzlar";
        }else if(animalc==8){
            hayvanadi="cikolalidonut";
        }else if(animalc==9){
            hayvanadi="dondurmakulahlar";
        }else if(animalc==10){
            hayvanadi="cilkelidonut";
        }else if(animalc==11){
            hayvanadi="hamburgers";
        }else if(animalc==12){
            hayvanadi="hotdoglar";
        }else if(animalc==13){
            hayvanadi="patates";
        }else if(animalc==14){
            hayvanadi="pizaalar";
        }else if(animalc==15){
            hayvanadi="kirazlar";
        }
        yemeks = GameObject.FindGameObjectsWithTag("yemeks");
        for (int i=0; i<yemeks.Length; i++){
            string adi = yemeks[i].name;
            if(adi!=hayvanadi){
                yemeks[i].SetActive(false);
            }
        }
    }

    public void havuc(){
        PlayerPrefs.SetInt("yemekler",1);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/havuclar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void karpuz(){
        PlayerPrefs.SetInt("yemekler",2);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/karpuzlar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void tavukbut(){
        PlayerPrefs.SetInt("yemekler",3);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/tavukbutlar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void dondurma(){
        PlayerPrefs.SetInt("yemekler",4);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmalar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void portakal(){
        PlayerPrefs.SetInt("yemekler",5);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/portiler/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void peynir(){
        PlayerPrefs.SetInt("yemekler",6);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/peynirs/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void muz(){
        PlayerPrefs.SetInt("yemekler",7);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/muzlar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }
    public void cikodonut(){
        PlayerPrefs.SetInt("yemekler",8);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/cikolalidonut/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void kulah(){
        PlayerPrefs.SetInt("yemekler",9);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri/dondurmakulahlar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void cilekdonut(){
        PlayerPrefs.SetInt("yemekler",10);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/cilkelidonut/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void hamburger(){
        PlayerPrefs.SetInt("yemekler",11);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hamburgers/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void hotdog(){
        PlayerPrefs.SetInt("yemekler",12);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/hotdoglar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void patates(){
        PlayerPrefs.SetInt("yemekler",13);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/patates/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void pizza(){
        PlayerPrefs.SetInt("yemekler",14);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/pizaalar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }
    public void kiraz(){
        PlayerPrefs.SetInt("yemekler",15);
        tiksilme();
        butonimage = GameObject.Find("Canvas/yemelikler/yemekskinleri2/kirazlar/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void sayfa1(){
        Animator animatorc = sayfaK.GetComponent<Animator>();
        animatorc.SetBool("yemesayfa", true);
    }

    public void sayfa2(){
        Animator animatorc = sayfaK.GetComponent<Animator>();
        animatorc.SetBool("yemesayfa", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
