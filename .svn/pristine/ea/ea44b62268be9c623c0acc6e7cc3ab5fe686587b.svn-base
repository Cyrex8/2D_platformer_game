using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class MoveableEnemy : Enemy {

    [SerializeField]
    private float speed = 5.0f;

    private Bullet bullet;
    private SpriteRenderer sprite;
    private Vector3 direction;
    protected override void Awake()
    {
        bullet = Resources.Load<Bullet>("Bullet");
        sprite = GetComponentInChildren<SpriteRenderer>();
       
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.GetComponent<Bullet>();

        if (bullet)
        {
            ReceiveDamage();

        }

     
    }

    protected override void Start()
    {
        direction = transform.right;
    }
    protected override void Update()
    {
        Move();
    }
  
    private void Move()
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.8F + transform.right * (direction.x) * 1F, 0.1F);

      
        if (colliders.Length > 0 && colliders.All(x=>!x.GetComponent<Character>()) )
        {
            direction.x *= -1;       
        }
      
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x > 0.0F;
        
    }
}
