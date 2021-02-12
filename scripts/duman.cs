using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duman : MonoBehaviour
{
    public float yokolma;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, yokolma);
    }
}
