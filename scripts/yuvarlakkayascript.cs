using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuvarlakkayascript : MonoBehaviour
{
    Rigidbody rigid;
    public float y;
    public float mass = 10000;
    public GameObject kirik;
    public AudioSource kirilmasesi;
    public GameObject toz;
    Vector3 vektor;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        vektor = new Vector3(0, 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < y)
        {
            rigid.mass = mass;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tahta")
        {
            //Instantiate(kirik, transform.position, transform.rotation);
            Destroy(gameObject,0.1f);
            kirilmasesi.Play();
            Instantiate(toz, transform.position-vektor, transform.rotation);
            Instantiate(kirik, transform.position, transform.rotation);
        }
        if (collision.gameObject.tag == "duvarkir")
        {
            //Instantiate(kirik, transform.position, transform.rotation);
            Destroy(gameObject, 0.1f);
            kirilmasesi.Play();
            Instantiate(toz, transform.position - vektor, transform.rotation);
            Instantiate(kirik, transform.position, transform.rotation);
        }
        if (collision.gameObject.tag == "kazik")
        {
            //Instantiate(kirik, transform.position, transform.rotation);
            Destroy(gameObject, 0.1f);
            kirilmasesi.Play();
            Instantiate(toz, transform.position - vektor, transform.rotation);
            Instantiate(kirik, transform.position, transform.rotation);
        }
        if (collision.gameObject.tag == "yer")
        {
            //Instantiate(kirik, transform.position, transform.rotation);
            Destroy(gameObject, 0.1f);
            kirilmasesi.Play();
            Instantiate(toz, transform.position - vektor, transform.rotation);
            Instantiate(kirik, transform.position, transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "tahta")
        {
            //Instantiate(kirik, transform.position, transform.rotation);
            Destroy(gameObject, 0.1f);
            kirilmasesi.Play();
            Instantiate(toz, transform.position - vektor, transform.rotation);
            Instantiate(kirik, transform.position, transform.rotation);
        }
    }
}
