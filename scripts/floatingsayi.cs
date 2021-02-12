using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingsayi : MonoBehaviour
{
    float hiz = 2;
    public float yokol = 1;
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime * hiz;
        transform.Rotate(2, 0, 0);
        Destroy(gameObject, yokol);
    }
}
