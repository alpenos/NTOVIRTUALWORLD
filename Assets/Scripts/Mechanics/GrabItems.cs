using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItems : MonoBehaviour
{
    public AudioClip CollectAudio;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Collectable")
        {
            PlayerPrefs.SetInt($"{col.gameObject.name}", 1);
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(CollectAudio, col.gameObject.transform.position);
        }
    }
}
