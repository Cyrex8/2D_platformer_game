﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private float speed = 10F;
    private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }
    private GameObject parent;

    public GameObject Parent { set { parent = value; } get { return parent; } }
    public Color color
    {
        set { sprite.color = value; }

    }

    



    private SpriteRenderer sprite;
    
    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        Destroy(gameObject, 2.0F);

    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x > 0.0F;
       
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        BaseChar basechar = collider.GetComponent<BaseChar>();
        if(basechar && basechar.gameObject !=parent)
        {
            Destroy(gameObject);

        }
        
    }
   
    



}
