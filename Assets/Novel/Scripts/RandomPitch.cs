using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPitch : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<AudioSource>().pitch = Random.Range(0.8f, 0.9f);
    }
}
