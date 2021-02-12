using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yapismasilme : MonoBehaviour
{
    private int sayac = 0;
    public GameObject fiskir;
    Quaternion donuk;
    private int a = 0;
    public int olum = 20;
    void Start()
    {
        donuk = Quaternion.Euler(transform.eulerAngles.x+45,transform.eulerAngles.y+90,transform.eulerAngles.z+45);
    }

    // Update is called once per frame
    void Update()
    {
        if (sayac > olum) {
            if (a == 0) { Instantiate(fiskir, transform.position, transform.rotation); a++; }
            
            transform.position = new Vector3(-100, -100, -100);
            //Destroy(gameObject);
                        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "su") 
        {
            sayac++;
            //Instantiate(fiskir, transform.position, transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "su")
        {
            sayac++;
            
        }
    }
}
