using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donuskapamayokolma : MonoBehaviour
{
    //public float sinirkucuk;
    //public float sinirbuyuk;
    public float siniry;
    public float olmevakti = 0;
    public GameObject obje;
    public GameObject obje2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obje.transform.position.y < siniry)
        {
            Destroy(gameObject, olmevakti);

        }
        if (obje2.transform.position.y < siniry)
        {
            Destroy(gameObject, olmevakti);

        }
        //if (obje.transform.position.x > sinirbuyuk)
        // {
        //     Destroy(gameObject, olmevakti);
        // }
    }
}
