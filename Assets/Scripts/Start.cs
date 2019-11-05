using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {
    public int nextlevel = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(nextlevel);
        }


    }
}
