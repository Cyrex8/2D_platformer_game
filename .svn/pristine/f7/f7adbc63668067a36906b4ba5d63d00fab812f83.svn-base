using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : Enemy {
    [SerializeField]
    private float rate = 2.0F;
    [SerializeField]
    private Color bulletColor = Color.white;
    private Bullet bullet;


    protected override void Awake()
    {
        bullet = Resources.Load<Bullet>("Bullet");
    }

    protected override void Start()
    {
        InvokeRepeating("Shoot", rate, rate);
    }

    private void Shoot()
    {
        Vector3 position = transform.position; position.y += 0.5F;

        Bullet newbullet = Instantiate(bullet, position, bullet.transform.rotation) as Bullet;
        newbullet.Parent = gameObject;
        newbullet.Direction = -newbullet.transform.right;
        newbullet.color = bulletColor; 


    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        BaseChar basechar = collider.GetComponent<BaseChar>();

        if (basechar && basechar is Character)
        {
            if (Mathf.Abs(basechar.transform.position.x - transform.position.x) < 0.3F) ReceiveDamage();

            ReceiveDamage();

        }
    
}
}
