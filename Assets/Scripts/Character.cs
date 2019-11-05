﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Character : BaseChar {
    [SerializeField]
    private float speed=5.0F;
    [SerializeField]
    private float jumpPower=7.0F;
    [SerializeField]
    private int lives = 5;
    public int Lives
    {
        get { return lives; }
        set { if (value <= 5) lives = value;
            HpBar.Refresh();
        }
    }
    private HpBar HpBar;
    private Rigidbody2D rigidbody;
    private SpriteRenderer sprite;
    private bool isGrounded=false;
    private Bullet bullet;
    private Animator animator;
   



    private CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }

    }
    private void Awake()
    {
        animator = GetComponent<Animator>();    
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();

        bullet = Resources.Load<Bullet>("Bullet");
        HpBar = FindObjectOfType<HpBar>(); 
    }
    private void FixedUpdate()
    {
     
        CheckGround();

    }
    private void Update()
    {

        if(isGrounded) State = CharState.Idle;
        if (Input.GetButton("Horizontal")) Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();

        if (Input.GetButtonDown("Fire1")) Shooting();
    }
private void Run()
    {
       
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0F;
        if (isGrounded) State = CharState.Run;


    }
    private void Jump()
    {
        if (isGrounded) State = CharState.Jump;
        rigidbody.AddForce(transform.up*jumpPower,ForceMode2D.Impulse);

    }
    private void CheckGround()
    {
        
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.7F);
                 isGrounded = colliders.Where(m => m.tag  != "Bullet").Count() > 1;

        if (!isGrounded) State = CharState.Jump;
    }

    private void Shooting()
    {
        Vector3 position = transform.position; position.y += 1F;
       Bullet newBullet= Instantiate(bullet,position, bullet.transform.rotation) as Bullet;
        newBullet.Parent = gameObject;
        newBullet.Direction = newBullet.transform.right * (sprite.flipX ? -1.0F : 1.0F);

    }

    public override void ReceiveDamage()
    {
       
        Lives--;
        rigidbody.velocity = Vector3.zero;
        if (isGrounded)
        {
            rigidbody.AddForce(transform.up*5.0f, ForceMode2D.Impulse);
        }
        else
        {
            rigidbody.AddForce(transform.up*-2.0f, ForceMode2D.Impulse);
        }
            Debug.Log(lives);
        if (lives <= 0) Die();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        BaseChar basechar = collision.gameObject.GetComponent<BaseChar>();
        if (basechar)
        {
            
            ReceiveDamage();
        }
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if(bullet && bullet.Parent != gameObject)
        {
            ReceiveDamage();
        }

    }




}
public enum CharState
{
    Idle,
    Run,
    Jump

}