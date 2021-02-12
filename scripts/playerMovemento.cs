using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovemento : MonoBehaviour
{
    public float hiz;
    public Joystick joystick;

    float moveHorizontal;
    float moveVertical;

    public Rigidbody rb;

    Vector3 harekat;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        moveHorizontal = -joystick.Horizontal;
        moveVertical = -joystick.Vertical;
        harekat = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = harekat * hiz;




        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + harekat * hiz * Time.fixedDeltaTime);

        float angle = Mathf.Atan2(harekat.z, harekat.x) * Mathf.Rad2Deg;

        //Debug.Log(angle);

        angle = angle - 90f;

        transform.eulerAngles = new Vector3(0, -angle, 0);
    }
}
