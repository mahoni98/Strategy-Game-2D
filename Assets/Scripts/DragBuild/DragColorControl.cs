using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragColorControl : MonoBehaviour
{
    [SerializeField] private Color Green;
    [SerializeField] private Color Red;

    [SerializeField] private Image BuildImage;

    private void Start()
    {
        BuildImage = GetComponent<Image>();
        //SetColor();
    }
    public void SetColor(WhichColor _Color)
    {
        //BuildImage.color
        if (_Color == WhichColor.GreenOne)
            BuildImage.color = Green;
        else if(_Color == WhichColor.RedOne)
            BuildImage.color = Red;
        else
            BuildImage.color = Color.white;

    }
    public enum WhichColor
    {
        GreenOne,
        RedOne,
        Default
    }
}
