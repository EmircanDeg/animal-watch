using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borusuyu : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(100, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rigid.AddForce(200, 0, 0);
    }
}
