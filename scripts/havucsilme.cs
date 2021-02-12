using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havucsilme : MonoBehaviour
{
    private bool sil = false;
    public GameObject kutu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sil = kutu.GetComponent<kutukirilma>().carpma;
        if(sil == true) { Destroy(gameObject); }
    }
}
