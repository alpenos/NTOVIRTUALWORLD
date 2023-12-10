using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToSave : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex);
    }
}
