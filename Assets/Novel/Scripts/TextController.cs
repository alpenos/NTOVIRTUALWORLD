using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private GameObject charSound;
    [SerializeField] private GameObject soundSkip;
    [SerializeField] private GameObject skipButton;
    [SerializeField] private Text historyText;
    float timeLeft = 0f;
    float phraseDelay;
    float charDelay = 0.25f;
    [SerializeField] private Text phraseUI;
    [SerializeField] private Text nameUI;
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject background;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private Sprite[] backgrounds;
    [SerializeField] private string[] name;
    [SerializeField] private string[] phrase;
    private int index = 0;
    private int historyIndex = 0;
    private bool isPressed;

    [SerializeField] private int maxIndex;
    [SerializeField] private GameObject fadeObject;
    public Transform parent;
    private bool IsLoading = false;

    void Awake()
    {
        index = PlayerPrefs.GetInt("index");
    }
    void Start()
    {
        historyIndex = index;
        StartCoroutine(textController());
        timeLeft = phrase[index].Length * 0.05f;
        for (int i = historyIndex; i <= index; i++)
        {
            historyText.text += $"\n {name[index]}: {(phrase[index].ToLower())} \n";
        }
    }
    void Update()
    {
        if (index > 0)
        {
            if (timeLeft <= 0)
            {
                skipButton.SetActive(true);
                if (isPressed)
                {
                    isPressed = false;
                    historyIndex = index;
                    Instantiate(soundSkip, transform.position, Quaternion.identity);
                    StartCoroutine(textController());
                    for (int i = historyIndex; i <= index; i++)
                    {
                        historyText.text += $"\n {name[index]}: {(phrase[index].ToLower())} \n";
                    }
                    timeLeft = phrase[index].Length * 0.06f;
                }
            }
            else
            {
                skipButton.SetActive(false);
                timeLeft -= Time.deltaTime;
            }
        }
        if (index == maxIndex && IsLoading == false)
        {
            IsLoading = true;
            PlayerPrefs.SetInt("index", 0);
            StartCoroutine(FadeDelay());
        }
    }

    IEnumerator textController()
    {
        phraseUI.text = "";
        nameUI.text = name[index];
        character.GetComponent<Image>().sprite = sprites[index];
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[index];
        for (int i = 0; i < phrase[index].Length; i++)
        {
            Instantiate(charSound, transform.position, Quaternion.identity);
            phraseUI.text += phrase[index][i];
            yield return new WaitForSeconds(0.05f);
        }
        Save();
        index++;
    }
    void Save()
    {
        PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("index", index);
    }
    public void IsPressed()
    {
        isPressed = true;
    }
    public void HistoryShow(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    IEnumerator FadeDelay()
    {
        Instantiate(fadeObject, transform.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
