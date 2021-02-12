using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinir : MonoBehaviour
{
    public float ysinir;
    public float ysinirbitis;
    public float xsinir;
    public float xsinirbitis;
    public float zsinir = -0.16f;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 vektorz = new Vector3(transform.position.x, transform.position.y, zsinir);
        transform.position = vektorz;
        if (transform.position.y > ysinir) {
            Vector3 vektory = new Vector3(transform.position.x, ysinir, transform.position.z);
            transform.position = vektory;
        }

        if (transform.position.y < ysinirbitis)
        {
            Vector3 vektorybitis = new Vector3(transform.position.x, ysinirbitis, transform.position.z);
            transform.position = vektorybitis;
        }
        if (transform.position.x > xsinir)
        {
            Vector3 vektorx = new Vector3(xsinir, transform.position.y, transform.position.z);
            transform.position = vektorx;
        }
        if (transform.position.x < xsinirbitis)
        {
            Vector3 vektorxbitis = new Vector3(xsinirbitis, transform.position.y, transform.position.z);
            transform.position = vektorxbitis;
        }
    }
    private void FixedUpdate()
    {
        Vector3 vektorz = new Vector3(transform.position.x, transform.position.y, zsinir);
        transform.position = vektorz;
        if (transform.position.y > ysinir)
        {
            Vector3 vektory = new Vector3(transform.position.x, ysinir, transform.position.z);
            transform.position = vektory;
        }

        if (transform.position.y < ysinirbitis)
        {
            Vector3 vektorybitis = new Vector3(transform.position.x, ysinirbitis, transform.position.z);
            transform.position = vektorybitis;
        }
        if (transform.position.x > xsinir)
        {
            Vector3 vektorx = new Vector3(xsinir, transform.position.y, transform.position.z);
            transform.position = vektorx;
        }
        if (transform.position.x < xsinirbitis)
        {
            Vector3 vektorxbitis = new Vector3(xsinirbitis, transform.position.y, transform.position.z);
            transform.position = vektorxbitis;
        }
    }
}
