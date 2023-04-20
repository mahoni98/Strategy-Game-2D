using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Drag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    

    [SerializeField] private Canvas Canvas;
    [SerializeField] private float Sensivity;
    [SerializeField] private DragColorControl _DragColorControl;

    private void Start()
    {
        Canvas = FindObjectOfType<Canvas>();
        //_Collider = GetComponent<Collider2D>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (DragManager.Instance.Entry)
        {
            DragManager.Instance.Entry = false;
            DragManager.Instance.Build = transform;
            //_DragColorControl.
        }

        //if (DragManager.Instance.Entry)
        //{
        //    //_DiceUpAndDown.Up();

        //    DragManager.Instance.Entry = false;

        //    DragManager.Instance.CurrentDice = transform;

        //    //_Collider.enabled = false;
        //}
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        DragManager.Instance.Entry = true;
        DragManager.Instance.SetPosition(GridInfo.Instance.GetClosestEnemy(DragManager.Instance.Build));
        //_Collider.enabled = true;
        //_DiceUpAndDown.Down();
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData PointerData = (PointerEventData)data;

        Vector2 Position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)Canvas.transform, PointerData.position, Canvas.worldCamera, out Position);
        transform.position = Vector2.Lerp(transform.position, Canvas.transform.TransformPoint(Position), Sensivity * Time.deltaTime);
    }
}
