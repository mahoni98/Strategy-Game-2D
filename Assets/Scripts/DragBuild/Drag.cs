using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drag : MonoBehaviour, IPointerDownHandler
{

    [SerializeField] private Transform CornerPos;
    [SerializeField] private Transform Parent;

    public void OnPointerDown(PointerEventData eventData)
    {
        DragManager.Instance.Build = CornerPos;
        DragManager.Instance.Entry = true;
        var inter = Parent.GetComponent<IProduct>();
        if (inter != null)
            GetProductInfo.Instance.SetInfoToPanel(Parent.GetComponent<Product>());
    }
}

