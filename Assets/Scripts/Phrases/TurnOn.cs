using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "phrase")
        {
            foreach (Transform child in col.gameObject.transform)
            {
                child.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}
