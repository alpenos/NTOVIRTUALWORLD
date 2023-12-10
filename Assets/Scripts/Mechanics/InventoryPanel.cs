using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public GameObject[] images;
    void Update()
    {
        UpdateImages();
    }

    void UpdateImages()
    {
        int previ = 0;
        int availableImages = 0;
        float imgpos = 50;
        for (int i = 0; i < images.Length; i++)
        {
            if (PlayerPrefs.GetInt($"{images[i].name}") == 1)
            {
                availableImages++;
                Vector2 imagePosition = new Vector3(imgpos, 0);
                gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, imgpos + images[i].GetComponent<RectTransform>().sizeDelta.x + 50);
                images[i].SetActive(true);
                images[i].GetComponent<RectTransform>().anchoredPosition = imagePosition;
                imgpos += images[i].GetComponent<RectTransform>().sizeDelta.x + 50;
            }
        }
    }
}