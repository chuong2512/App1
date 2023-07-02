using UnityEngine;
using UnityEngine.UI;

public class ButtonPage : MonoBehaviour
{
    public Image image;
    public Sprite chooseImage, unChooseIamge;
    public Color32 ChooseColor32, unChooseColor;
    
    public void Select()
    {
        //image.sprite = chooseImage;
        image.color = ChooseColor32;
    }
    
    public void UnSelect()
    {
        //image.sprite = unChooseIamge;
        image.color = unChooseColor;
    }
}