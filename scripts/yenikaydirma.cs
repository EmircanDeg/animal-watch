using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenikaydirma : MonoBehaviour
{
    // Start is called before the first frame update
    /* public float y;
     void Start()
     {

     }

     void OnMouseDrag()
      {
          Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 32);
          Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

          transform.position = new Vector3(objPosition.x,y,transform.position.z);
      }
     void Update()
     {

     }*/
    private Vector3 mouspozisyonu;
    private Vector3 pos;
    private Vector3 ilkPos;
    bool basma;
    float dist = 10;
    public float y;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            ilkPos = Camera.main.ScreenToWorldPoint(mouspozisyonu) - transform.position;
        }
        basma = true;
    }
    private void OnMouseDrag()
    {
        mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        pos = Camera.main.ScreenToWorldPoint(mouspozisyonu);
        if (basma)
            transform.position = new Vector3(pos.x - ilkPos.x, transform.position.y, transform.position.z); //pos - initialPos;
    }
    private void OnMouseUp()
    {
        basma = false;
    }
}
