using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseChar {


   protected virtual void Awake()
    {

    }

    protected virtual void Start()
    {

    }
    protected virtual void Update()
    {

    }


    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {



        


        BaseChar basechar = collider.GetComponent<BaseChar>();

        if (basechar && basechar is Character)
        {
            if (Mathf.Abs(basechar.transform.position.x - transform.position.x) < 0.3F) ReceiveDamage();
            
            ReceiveDamage();

        }
    }
  
}
