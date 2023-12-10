using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ButtonSoundAnimation : MonoBehaviour
{
    AudioSource audioData;

    void OnEnable()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
}