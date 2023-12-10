using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObject : MonoBehaviour
{
    [SerializeField] GameObject ObjectToShow;
    [SerializeField] private GameObject fadeObject;
    [SerializeField] private Transform parent;

    public void Show()
    {
        if (PlayerPrefs.GetString("scene") == "" && PlayerPrefs.GetInt("index") == 0)
        {
            StartCoroutine(FadeDelay());
        }
        else
        {
            ObjectToShow.SetActive(true);
        }
    }
    public void Disappear()
    {
        ObjectToShow.SetActive(false);
    }


    IEnumerator FadeDelay()
    {
        Instantiate(fadeObject, transform.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
