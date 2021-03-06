﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaydirmacaprazters : MonoBehaviour
{
    private float dist;
    private float dist1;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject duvar1;
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        Vector3 v3;

        if (Input.touchCount != 1)
        {
            dragging = false;
            return;
        }

        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "DraggableCapraz2"))
            {
                Debug.Log("Here");
                toDrag = hit.transform;
                dist = hit.transform.position.z - Camera.main.transform.position.z;
                dist1 = hit.transform.position.y - Camera.main.transform.position.y;

                v3 = new Vector3(pos.x, pos.y, dist);
                v3 = Camera.main.ScreenToWorldPoint(v3);
                offset = toDrag.position - v3;
                dragging = true;
            }
        }
        if (dragging && touch.phase == TouchPhase.Moved)
        {
            v3 = new Vector3(Input.mousePosition.x, -Input.mousePosition.x, dist);
            v3 = Camera.main.ScreenToWorldPoint(v3);
            toDrag.position = v3 + offset;
        }
        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
        }
    }
}

