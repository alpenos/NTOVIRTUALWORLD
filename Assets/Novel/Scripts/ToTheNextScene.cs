using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheNextScene : MonoBehaviour
{
    [SerializeField] private GameObject fadeObject;
    [SerializeField] private Transform parent;
    public void LoadScene()
    {
        StartCoroutine(FadeDelay());
    }

    IEnumerator FadeDelay()
    {
        Instantiate(fadeObject, transform.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
