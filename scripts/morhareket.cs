using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morhareket : MonoBehaviour
{
    public bool hareket;
    public GameObject hareketci;
    //private float speed = 6.085f;
    //public float zaman;
   //public float sayac;
    //public float sayac2;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (hareket== true)
        {
            //if (sayac < zaman) { transform.position = transform.position + new Vector3(1, 0, 0) * speed; sayac = sayac + Time.deltaTime; }

            //sayac2 = 0;

            
        }

        if (hareket == false)
        {
            //if (sayac2 < zaman) { transform.position = transform.position + new Vector3(-1, 0, 0) * speed; sayac2 = sayac2 + Time.deltaTime; }
            //sayac = 0;
        }
     }

    void Update()
    {
        
        Debug.Log("XX = " + hareket);
    }
}
