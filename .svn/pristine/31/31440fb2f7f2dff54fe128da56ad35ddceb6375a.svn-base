using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour {
     //public bool onGround;
     private Rigidbody rb;
    //public float jumpSpeedY;
    //bool facingRight, Jumping;
    public float jumpspeed;
    private Animator anim;    
     private float speed=2.0f;
    // Use this for initialization
    void Start () {
         anim = GetComponent<Animator>();
        //onGround = true;
        rb = GetComponent<Rigidbody>();
}

     // Update is called once per frame
     void Update () {
        float trans= Input.GetAxis("Horizontal")*speed;
        trans *=Time.deltaTime;
        transform.Translate(0,0,trans);
        if (trans != 0)
        {
            anim.SetInteger("State", 1);
        }
        else 
        {
            anim.SetInteger("State", 0);
        }
        transform.Translate(0, 0, trans);
        /*if  (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, jumpspeed, 0);
        }*/
        /*if(onGround)
       {
           if (Input.GetButtonDown("Jump"))
           {
               rb.velocity = new Vector3(0f, 5f, 0f);
               onGround = false;
           }
       }*/
    }
    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }*/
}
