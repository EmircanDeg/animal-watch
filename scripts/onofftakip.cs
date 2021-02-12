using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onofftakip : MonoBehaviour
{
    public GameObject takiplik;
    Vector3 vektor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vektor = new Vector3(takiplik.transform.position.x-137,transform.position.y,transform.position.z);
        //if (transform.position.x < -232) { vektor = new Vector3(takiplik.transform.position.x,-360,0); }
        //else { transform.position= new Vector3(transform.position.x, -360, 0); }
        transform.position = vektor;
    }
}
