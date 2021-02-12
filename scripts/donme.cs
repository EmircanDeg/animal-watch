using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{

    Vector3 rotationEuler;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rotationEuler += Vector3.forward * 30 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotationEuler);
    }
    void Update()
    {
        
    }
}
