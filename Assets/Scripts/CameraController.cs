using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private float speed = 2.0F;
    [SerializeField]
    private Transform target;

    private void Awake()
    {
        var CharacterData = FindObjectOfType<Character>();
        if (CharacterData != null)
        {
            if (!target) target = CharacterData.transform;
        }
        else
        {
            var BaseScriptData = FindObjectOfType<BaseScript>();
            if (BaseScriptData != null)
            {
                if (!target) target = BaseScriptData.transform;
            }
        }

    }
 
    private void Update()
    {
        if (transform != null && target!=null)
        {
            Vector3 position = target.position; position.z = -25.0F;
            transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
        }
    }
   
}
