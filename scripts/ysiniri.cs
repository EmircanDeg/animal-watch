using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ysiniri : MonoBehaviour
{
    public float ysinir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vektory = new Vector3(transform.position.x, ysinir, transform.position.z);
        transform.position = vektory;
    }
}
