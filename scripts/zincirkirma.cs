using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zincirkirma : MonoBehaviour
{
    public GameObject sonzincir;
    void Start()
    {
        //sonzincir = GameObject.FindGameObjectWithTag("sonzincir");
    }

    void OnMouseDown()
    {
        //Destroy(gameObject);
        Destroy(sonzincir);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
