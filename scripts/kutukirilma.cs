using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutukirilma : MonoBehaviour
{
    public GameObject yemek;
    public GameObject kirik;
    public bool carpma = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "yer")
        {
            carpma = true;
            
            Instantiate(kirik, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yer") {
            Destroy(gameObject);
            Instantiate(kirik, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
            Instantiate(yemek, transform.position, transform.rotation);
        }
        
    }
}
