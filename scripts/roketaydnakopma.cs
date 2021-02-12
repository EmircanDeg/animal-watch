using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketaydnakopma : MonoBehaviour
{
    public float hiz = 1;
    public float x;
    public float y;
    public float dx;
    public float dy;
    public float dz;
    void Start()
    {
        /*PlayerPrefs.SetInt("kutupayi",0);
        PlayerPrefs.SetInt("kedigri", 0);
        PlayerPrefs.SetInt("kopek_acıkkahve", 0);
        PlayerPrefs.SetInt("ayi_genel", 0);
        PlayerPrefs.SetInt("kopek_kahve", 0);*/
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(x, y, 0) * hiz;
        transform.Rotate(dx, dy, dz);
    }
    void Update()
    {
        
    }
}
