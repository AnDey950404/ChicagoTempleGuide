using UnityEngine;
using UnityEngine.UI;

public class PhotoChanger : MonoBehaviour
{
    [Header("照片顯示")]
    public Image background;

    [Header("地點照片")]
    public Sprite entrancePhoto;
    public Sprite templePhoto;

    [Header("各地點按鈕")]
    public GameObject entranceHotspots;
    public GameObject templeHotspots;

    private void Start()
    {
        ShowEntrance();
    }

    public void ShowEntrance()
    {
        background.sprite = entrancePhoto;

        entranceHotspots.SetActive(true);
        templeHotspots.SetActive(false);
    }

    public void ShowTemple()
    {
        background.sprite = templePhoto;

        entranceHotspots.SetActive(false);
        templeHotspots.SetActive(true);
    }
}