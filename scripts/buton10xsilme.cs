using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton10xsilme : MonoBehaviour
{
    bool silme;
    public GameObject reklam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        silme = reklam.GetComponent<reklamlar>().reklamoynadi;
        if (silme == true) { Destroy(gameObject); }
    }
}
