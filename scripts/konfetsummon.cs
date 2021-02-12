using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konfetsummon : MonoBehaviour
{
    /*public GameObject kotfeti;
    public float ilk;
    public float son;
    public float sayac = 0;
    public float cikmavakti = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        sayac = sayac + Time.deltaTime;
        if (sayac > cikmavakti)
        {
            Instantiate(kotfeti, transform.position, transform.rotation);
            transform.position = new Vector3(Random.Range(son, ilk), transform.position.y, transform.position.z);
            
            sayac = 0;

        }

    }*/
    public float hiz = 2;
    public float yokol = 1;
    void Start()
    {
        //transform.eulerAngles = new Vector3(0, 0, 90);
        gameObject.transform.localScale=Vector3.one * Random.Range(0.05f, 0.3f);
        hiz = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime * hiz;
        transform.Rotate(Random.Range(0.5f,2), Random.Range(0.5f, 2), Random.Range(0.5f, 2));
        Destroy(gameObject, yokol);
    }
}
