﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    Instructions _C_instructions;

    public Rigidbody2D rb;

    public float shrinkSpeed = 3f;
   // public GameObject DialogueManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0;
        //DialogueManager.SetActive(true);
        rb.rotation = Random.Range(0,360);
        transform.localScale = Vector3.one * 10f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= (Vector3.one * shrinkSpeed * Time.deltaTime);

        if (transform.localScale.x <= 0.5f)
        {
            Destroy(gameObject);
        }
      
    }
}
