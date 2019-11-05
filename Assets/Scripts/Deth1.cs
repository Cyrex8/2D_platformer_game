using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deth1 : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collider) {
        BaseChar basechar = collider.GetComponent<BaseChar>();
        if(basechar && basechar is Character)
        {
            basechar.ReceiveDamage();

        }
    }

}
