using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullhareket : MonoBehaviour
{
    public float hiz;
    public float zaman = 0;
    void Start()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * hiz;
    }

    // Update is called once per frame
    void Update()
    {
        zaman = zaman + Time.deltaTime;
        if (zaman < 0.5f) { transform.position = transform.position + new Vector3(0.1f, 0, 0) * hiz; }
        if(zaman>0.5f && zaman < 1) { transform.position = transform.position + new Vector3(-0.1f, 0, 0) * hiz; }
        if(zaman > 1) { zaman = 0; }
    }
}
