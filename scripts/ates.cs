using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{

    public float olum = 1;
   
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "su")
        {
            
            Destroy(gameObject, olum);

        }
        if (collision.gameObject.tag == "yokedici")
        {

            Destroy(gameObject, olum);

        }
    }
    
    void Update()
    {
        
        

    }
}
