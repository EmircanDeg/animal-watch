using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketucma : MonoBehaviour
{
    public int hiz = 1;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * hiz;
        if (transform.position.y > 70) { Destroy(gameObject); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
