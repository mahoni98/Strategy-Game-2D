using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drag : MonoBehaviour, IPointerDownHandler
{

    [SerializeField] private Canvas Canvas;
    [SerializeField] private float Sensivity;

    [SerializeField] private Transform CornerPos;
    [SerializeField] private Transform Parent;

    private void Start()
    {
        Canvas = FindObjectOfType<Canvas>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        DragManager.Instance.Build = CornerPos;

        var inter = Parent.GetComponent<IProduct>();
        if (inter != null)
            GetProductInfo.Instance.SetInfoToPanel(Parent.GetComponent<Product>());
    }
    public void DragHandler(BaseEventData data)
    {
        PointerEventData PointerData = (PointerEventData)data;
        Vector2 Position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)Canvas.transform, PointerData.position, Canvas.worldCamera, out Position);
        transform.position = Vector2.Lerp(transform.position, Canvas.transform.TransformPoint(Position), Sensivity * Time.deltaTime);
    }
}
