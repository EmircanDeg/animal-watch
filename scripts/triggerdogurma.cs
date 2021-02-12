using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdogurma : MonoBehaviour
{
    public GameObject dogma;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kaya")
        {
            Instantiate(dogma, transform.position, transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kaya")
        {
            Instantiate(dogma, transform.position, transform.rotation);
        }
        if (collision.gameObject.tag == "sipci")
        {
            Instantiate(dogma, transform.position, transform.rotation);
        }
    }
}
