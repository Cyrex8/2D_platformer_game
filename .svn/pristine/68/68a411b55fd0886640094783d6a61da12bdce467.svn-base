using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChar : MonoBehaviour {
    private float speed;
    public bool Destroyed { get; set; }
    public virtual void ReceiveDamage()
    {
        Die();
    }   

    protected virtual void Die()
    {
        Destroyed = true;
        Destroy(gameObject);
    }
}
