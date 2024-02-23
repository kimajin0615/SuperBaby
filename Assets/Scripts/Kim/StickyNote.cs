using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickyNote : MonoBehaviour
{
    public Image BG_Image;
    public Text text;

    public void SetStickyNote(Sprite sprite, string name)
    {
        BG_Image.sprite = sprite;
        text.text = name;
    }
}
