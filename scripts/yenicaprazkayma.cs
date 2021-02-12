using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenicaprazkayma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 32);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = new Vector3(objPosition.x, objPosition.x, objPosition.z+3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
