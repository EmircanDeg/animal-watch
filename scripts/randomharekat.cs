using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomharekat : MonoBehaviour
{
    

    public float hiz;
    private int oldu = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (oldu == 0) { transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime / hiz; }
        if (oldu == 1) { transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime / hiz; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ustdur") { oldu = 1; }
        if (other.gameObject.tag == "altdur") { oldu = 0; }
    }
}

