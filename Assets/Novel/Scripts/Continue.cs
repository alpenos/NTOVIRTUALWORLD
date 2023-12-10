using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public GameObject music;
    public Transform parent;
    [SerializeField] private Animator fadeAnimator;
    [SerializeField] private GameObject fadeObject;
    public void Load()
    {
        StartCoroutine(FadeDelay());
    }
    IEnumerator FadeDelay()
    {
        music.SetActive(false);
        Instantiate(fadeObject, transform.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(PlayerPrefs.GetInt("scene"));
    }
}
