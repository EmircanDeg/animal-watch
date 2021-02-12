using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class su : MonoBehaviour
{
    int yer = 0;
    public float hiz= -0.01f;
    Rigidbody rb;
    public GameObject yapisma;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ates")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "yokedici")
        {

            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "yer")
        {
            Debug.Log("YER");
            gameObject.GetComponent<SphereCollider>().enabled = false;
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            rb.isKinematic = true;
            yer = 1;
            
        }
        if (collision.gameObject.tag == "yapiskan") { Instantiate(yapisma, transform.position, transform.rotation); }
        if (collision.gameObject.tag == "yapiskanac") { Instantiate(yapisma, transform.position, transform.rotation); }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ates")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (yer == 1)
        {

            transform.position = transform.position + new Vector3(0, hiz, 0)*Time.deltaTime;
        }
    }
}
