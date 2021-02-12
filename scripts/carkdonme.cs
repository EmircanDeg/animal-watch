using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carkdonme : MonoBehaviour
{
    public float hiz=1;
    public bool degdi = false;
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (degdi == false)
        {
            donme();
        }
        
    }
    void Update()
    {

       
        
    }
    public void donme()
    {
        gameObject.transform.Rotate(0, 0, hiz);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duvarkir")
        {
            degdi = true;

        }

        if (other.gameObject.tag == "yenitrigger")
        {
            degdi = false;
        }


    }
   

}
