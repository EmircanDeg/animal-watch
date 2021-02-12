using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffakma : MonoBehaviour
{
    SpriteRenderer spriterenderer;
    private float sure;
    public Sprite[] sprite;
    
    public int sayac;
    public float gecensure;
    
    
    
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        
    }

    void Animasyon1()
    {
        
     sure = sure + Time.deltaTime;
     if (sure > gecensure)
       {
        spriterenderer.sprite = sprite[sayac];
        sayac++;
        sure = 0;
       }
            if(sayac == sprite.Length) { sayac = 0; }
        
        

    }

    
    void Update()
    {
        Animasyon1();
        
        
    }

    
}
