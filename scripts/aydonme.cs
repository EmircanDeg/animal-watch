using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aydonme : MonoBehaviour
{
    public float hiz = 0.2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1)*hiz);
    }
}
