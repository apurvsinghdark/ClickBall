﻿using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class ClickOnObject : MonoBehaviour
{

    private void Start() {
    }

    private void OnMouseDown() {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
 
        if(hit.collider != null)
        {
            Debug.Log ("Target name: " + hit.collider.gameObject.transform.name);
        }
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = Vector2.up * 10f;
    }
}
