
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System;
public class Load : MonoBehaviour
{

    public float loadFloat = 0;
    public int loadInt = 0;
    public bool loadBool = false;
    public string[] loadArray;

    void LoadPlayerPrefs()
    {
        if (PlayerPrefs.HasKey("saveFloat")) loadFloat = PlayerPrefs.GetFloat("saveFloat");
        if (PlayerPrefs.HasKey("saveInt")) loadInt = PlayerPrefs.GetInt("saveInt");
        if (PlayerPrefs.HasKey("saveBool")) loadBool = bool.Parse(PlayerPrefs.GetString("saveBool"));

        int j = 0;
        List<string> tmp = new List<string>();
        while (PlayerPrefs.HasKey("elementArray_" + j))
        {
            tmp.Add(PlayerPrefs.GetString("elementArray_" + j));
            j++;
        }

        loadArray = new string[tmp.Count];
        for (int i = 0; i < tmp.Count; i++)
        {
            loadArray[i] = tmp[i];
        }
    }
}
