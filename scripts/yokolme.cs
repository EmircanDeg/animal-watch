using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokolme : MonoBehaviour
{
    public float sure;
    void Start()
    {
        sure = Random.Range(2.5f, 4);
        Destroy(gameObject, sure);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
