using UnityEngine;
using UnityEngine.UI;

public class PhotoChanger : MonoBehaviour
{
    public Image background;

    public Sprite photo;

    public void ChangePhoto()
    {
        background.sprite = photo;
    }
}