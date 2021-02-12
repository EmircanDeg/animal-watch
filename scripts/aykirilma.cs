using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aykirilma : MonoBehaviour
{
    public GameObject kirik;
    public GameObject efekt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(kirik, transform.position, transform.rotation);
        Instantiate(efekt, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
