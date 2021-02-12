using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daghareket : MonoBehaviour
{
    public float zaman;
    public float hiz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zaman = zaman + Time.deltaTime;
        if (zaman > 0 && zaman < 2) { transform.position = transform.position + new Vector3(1, 0, 0) * hiz; }
        else if (zaman > 2 && zaman < 4) { transform.position = transform.position + new Vector3(-1, 0, 0) * hiz; }
        else if (zaman > 4) { zaman = 0; }
    }
}
