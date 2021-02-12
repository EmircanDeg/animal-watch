using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skinPanelKodu : MonoBehaviour
{
    public GameObject[] tikler;
    public GameObject[] hayvans;
    private GameObject butonimage;
    private Image tikk;
    public int animalc;
    public GameObject animalOwn;
    public string hayvanadi;
    // Start is called before the first frame update
    void Start()
    {
        tiksilme();
        hayvandeact();
        karatoken();

        animalc = PlayerPrefs.GetInt("animal");
        if(animalc == 1 || animalc==0){
            butonimage = GameObject.Find("Canvas/skinPanel/geyikb/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;

        }else if(animalc == 2){
            butonimage = GameObject.Find("Canvas/skinPanel/ayib/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 3){
            butonimage = GameObject.Find("Canvas/skinPanel/koyuKop/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 4){
            butonimage = GameObject.Find("Canvas/skinPanel/acikKop/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 5){
            butonimage = GameObject.Find("Canvas/skinPanel/kutupayi/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 6){
            butonimage = GameObject.Find("Canvas/skinPanel/griKedi/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }else if(animalc == 7){
            butonimage = GameObject.Find("Canvas/skinPanel/kaveKedi/tik");
            tikk = butonimage.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 1f;
            tikk.color = tempColor;
        }
        
    }

    public void tiksilme(){
        tikler = GameObject.FindGameObjectsWithTag("skinTik");
        foreach (GameObject tikz in tikler){
            tikk = tikz.GetComponent<Image>();
            var tempColor = tikk.color;
            tempColor.a = 0f;
            tikk.color = tempColor;
        }
    }

    public void karatoken(){
        if(PlayerPrefs.GetInt("ayi_genel")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/ayik");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kutupayi")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/kutupk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kopek_kahve")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/koyukopk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kedigri")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/grikedik");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kopek_acıkkahve")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/ackkopk");
            animalOwn.SetActive(false);
        }if(PlayerPrefs.GetInt("kedikahve")==5){
            animalOwn = GameObject.Find("Canvas/skinPanel/kavekedik");
            animalOwn.SetActive(false);
        }
    }

    public void hayvandeact(){
        animalc = PlayerPrefs.GetInt("animal");
        if(animalc==1 || animalc==0){
            hayvanadi="geyik_genel1";
        }else if(animalc==2){
            hayvanadi="ayi_genel";
        }else if(animalc==3){
            hayvanadi="kopek_kahve";
        }else if(animalc==4){
            hayvanadi="kopek_acıkkahve";
        }else if(animalc==5){
            hayvanadi="kutupayi";
        }else if(animalc==6){
            hayvanadi="kedigri";
        }else if(animalc==7){
            hayvanadi="kedikahve";
        }
        hayvans = GameObject.FindGameObjectsWithTag("hayvan");
        for (int i=0; i<hayvans.Length; i++){
            string adi = hayvans[i].name;
            if(adi!=hayvanadi){
                hayvans[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void geyikPress(){
        PlayerPrefs.SetInt("animal",1);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/geyikb/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void ayiPress(){
        PlayerPrefs.SetInt("animal",2);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/ayib/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void koyuKopPress(){
        PlayerPrefs.SetInt("animal",3);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/koyuKop/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void acikKopPress(){
        PlayerPrefs.SetInt("animal",4);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/acikKop/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void kutupPress(){
        PlayerPrefs.SetInt("animal",5);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/kutupayi/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void griKediPress(){
        PlayerPrefs.SetInt("animal",6);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/griKedi/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }

    public void kaveKediPress(){
        PlayerPrefs.SetInt("animal",7);
        tiksilme();
        butonimage = GameObject.Find("Canvas/skinPanel/kaveKedi/tik");
        tikk = butonimage.GetComponent<Image>();
        var tempColor = tikk.color;
        tempColor.a = 1f;
        tikk.color = tempColor;
    }
}
