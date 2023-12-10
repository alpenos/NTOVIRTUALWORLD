using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public GameObject music;
    public Transform parent;
    [SerializeField] private Animator fadeAnimator;
    [SerializeField] private GameObject fadeObject;
    public void LoadScene()
    {
        StartCoroutine(FadeDelay());
    }
    IEnumerator FadeDelay()
    {
        music.SetActive(false);
        Instantiate(fadeObject, transform.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(0.6f);
        PlayerPrefs.SetInt("index", 0);
        PlayerPrefs.SetString("scene", "Test");
        Application.LoadLevel("Test");
    }
}
