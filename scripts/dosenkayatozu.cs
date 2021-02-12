using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dosenkayatozu : MonoBehaviour
{
    public GameObject toz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(toz, transform.position, transform.rotation);
    }
}
