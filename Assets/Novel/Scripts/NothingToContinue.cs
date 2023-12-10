using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NothingToContinue : MonoBehaviour
{
    [SerializeField] private GameObject continueButton;
    void Start()
    {
        if(PlayerPrefs.GetInt("scene") == 0)
        {
            continueButton.SetActive(false);
        }
        else
        {
            continueButton.SetActive(true);
        }
    }
}
