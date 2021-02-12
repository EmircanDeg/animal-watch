using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aykiriciroket : MonoBehaviour
{
    public float hiz=1;
    private float sayac;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime * hiz;
        sayac = sayac + Time.deltaTime;
        if (sayac > 0.5f) { hiz = hiz * 2;sayac = 0; }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
