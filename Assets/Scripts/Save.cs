
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System;

public class Save : MonoBehaviour {

    public float saveFloat = 0.25f;
    public int saveInt = 7;
    public bool saveBool = true;
    public string[] saveArray = { "Char", "Enemy"};

    

    public string fileName = "SaveData";

    void SavePlayerPrefs()
    {
        PlayerPrefs.SetFloat("saveFloat", saveFloat);
        PlayerPrefs.SetInt("saveInt", saveInt);
        PlayerPrefs.SetString("saveBool", saveBool.ToString());

        for (int i = 0; i < saveArray.Length; i++)
        {
            PlayerPrefs.SetString("elementArray_" + i, saveArray[i]);
        }
    }


    
 }

