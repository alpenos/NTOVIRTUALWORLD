using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoesCollectableObjectExist : MonoBehaviour
{
    void Start()
    {
        if(PlayerPrefs.GetInt($"{gameObject.name}") == 1)
        {
            Destroy(gameObject);
        }
    }
}
