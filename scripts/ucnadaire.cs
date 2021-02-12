using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucnadaire : MonoBehaviour
{
    public float donmehiz=1;
    public float ucmahiz=1;
    float zaman;
    public float gecenzaman;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        zaman = zaman + Time.deltaTime;
        transform.Rotate(0, donmehiz, 0);
        if (zaman > gecenzaman) { transform.position = transform.position + new Vector3(2, 1, 0)*Time.deltaTime*ucmahiz; donmehiz = donmehiz * 2; }
        if (zaman > gecenzaman+2) { transform.position = transform.position + new Vector3(2, 1, 0) * Time.deltaTime * ucmahiz*100; donmehiz = donmehiz * 2; }
    }
    void Update()
    {
        
    }
}
