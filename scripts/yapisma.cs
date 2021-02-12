using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yapisma : MonoBehaviour
{
    Rigidbody rigid;
    public GameObject cark;
    Transform trans;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        trans = gameObject.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yapiskan")
        {

            rigid.constraints = RigidbodyConstraints.FreezeAll;
            //GetComponent<SphereCollider>().enabled = false;
        }
        if (collision.gameObject.tag == "yapiskanac")
        {

            rigid.constraints = RigidbodyConstraints.FreezeAll;
            gameObject.transform.parent = cark.transform;
            //GetComponent<SphereCollider>().enabled = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "yapiskan")
        {

            rigid.constraints = RigidbodyConstraints.FreezePositionZ;
            //GetComponent<SphereCollider>().enabled = false;
        }
        if (collision.gameObject.tag == "yapiskanac")
        {

            rigid.constraints = RigidbodyConstraints.FreezePositionZ;
            gameObject.transform.parent = trans;
            //GetComponent<SphereCollider>().enabled = false;
        }
    }
}
