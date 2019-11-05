﻿using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class HpBar : MonoBehaviour
{
    private Character character;
    private Transform[] hearts = new Transform[5];
    private void Awake()
    {
        character = FindObjectOfType<Character>();
        for (int i = 1; i < hearts.Length; i++)
        {
            hearts[i] = transform.GetChild(i);
            Debug.Log(hearts[i]);
        }
    }
    public void Refresh()
    {

        for (int i = 1; i < hearts.Length; i++)

        {
            if (i < character.Lives)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
            {
                hearts[i].gameObject.SetActive(false);
            }
        }        
    }
}
