using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cikarici : MonoBehaviour
{
    public GameObject cikacak;
    public float sayac = 0;
    private int sayma = 0;
    public float cikmavakti = 0.5f;
    Vector3 vektor;
    public GameObject cikici;
    public float ilk;
    public float son;
    void Start()
    {
        vektor = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        sayac = sayac + Time.deltaTime;
        if (sayac > cikmavakti)
        {
            Instantiate(cikacak, transform.position, transform.rotation);
            transform.position = new Vector3(Random.Range(son, ilk), transform.position.y, transform.position.z);
            sayma++;
            sayac = 0;

        }
        
    }
}
