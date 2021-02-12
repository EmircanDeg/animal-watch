using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantarkod : MonoBehaviour
{
    public GameObject mantarsuyu;
    Vector3 vektor;
    void Start()
    {
        vektor = new Vector3(0, 0, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ates")
        {
            Instantiate(mantarsuyu, transform.position - vektor, transform.rotation);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
