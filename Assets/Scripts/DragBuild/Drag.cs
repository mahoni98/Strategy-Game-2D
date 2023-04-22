using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private Canvas Canvas;
    [SerializeField] private float Sensivity;


    [SerializeField] private Transform CornerPos;
    [SerializeField] private Transform Parent;


    public float OffsetX;
    public float OffsetY;


    private void Start()
    {
        Canvas = FindObjectOfType<Canvas>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //if (DragManager.Instance.Entry)
        //{
        //    DragManager.Instance.Entry = false;
        //    DragManager.Instance.Build = CornerPos;
        //}
        DragManager.Instance.Build = CornerPos;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        //DragManager.Instance.Entry = true;
    }


    public void DragHandler(BaseEventData data)
    {
        PointerEventData PointerData = (PointerEventData)data;

        Vector2 Position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)Canvas.transform, PointerData.position, Canvas.worldCamera, out Position);
        transform.position = Vector2.Lerp(transform.position, Canvas.transform.TransformPoint(Position), Sensivity * Time.deltaTime);
    }
}
