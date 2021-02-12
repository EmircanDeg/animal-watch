using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havuc : MonoBehaviour
{
    public GameObject havucsuyu;
    public GameObject zehirlihav;
    public GameObject artibir;
    Vector3 vektor;
    private int oldu = 0;
    void Start()
    {
        vektor = new Vector3(0, 0, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "ates") {
            Instantiate(havucsuyu, transform.position-vektor, transform.rotation);
            Destroy(gameObject); }
        if (collision.gameObject.tag == "zehirli")
        {
            Instantiate(zehirlihav, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hayvan")
        {
            if (oldu == 0)
            { 
                Instantiate(artibir, transform.position - vektor, transform.rotation);
                oldu = 1;
            }
            

        }
    }
    void Update()
    {
        
    }
}
