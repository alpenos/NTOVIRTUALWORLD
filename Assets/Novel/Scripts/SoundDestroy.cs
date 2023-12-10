using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(preDeath());
    }
    IEnumerator preDeath()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
