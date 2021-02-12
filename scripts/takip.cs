using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{
    public GameObject takiplik;
    Vector3 vektor;
    public float takipysi = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vektor = new Vector3(takiplik.transform.position.x+0.5f, takiplik.transform.position.y+takipysi, takiplik.transform.position.z);
        transform.position = vektor;
    }
}
