using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kazikkirilma : MonoBehaviour
{
    public GameObject kirikkazik;
    public AudioSource kirilmases;
    void Start()
    {
        
    }

  //  private void OnTriggerEnter(Collider other)
  //  {
   //     if (other.gameObject.tag == "kaya")
  //      {
    //        Destroy(gameObject);
    //        kirilmases.Play();
     //       Instantiate(kirikkazik,transform.position, transform.rotation);
    //    }
   // }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kaya")
        {
            Destroy(gameObject);
            kirilmases.Play();
            Instantiate(kirikkazik, transform.position, transform.rotation);
        }
        if (collision.gameObject.tag == "sipci")
        {
            Destroy(gameObject);
            kirilmases.Play();
            Instantiate(kirikkazik, transform.position, transform.rotation);
        }
    }
    void Update()
    {
        
    }
}
