using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeDelete : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Destroy());
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
