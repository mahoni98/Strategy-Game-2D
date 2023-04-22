using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ParentTriggerControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBuild
{
    [SerializeField] private CornerTrigger[] CornerTriggers;
    [SerializeField] private DragColorControl _DragColorControl;
    [SerializeField] private bool CanPlace;


    private void Start()
    {
        CornerTriggers = transform.GetComponentsInChildren<CornerTrigger>();
        _DragColorControl = GetComponent<DragColorControl>();
        DisabledTrigger();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        InvokeRepeating("CheckTrigger", 0.2f, 0.2f);
        EnabledTrigger();
    }
    public void CheckTrigger()
    {
        foreach (var item in CornerTriggers)
        {
            if (item.GridEmpt == false)
            {
                CanPlace = false;
                _DragColorControl.SetColor(DragColorControl.WhichColor.RedOne);
                return;
            }
            else
            {
                _DragColorControl.SetColor(DragColorControl.WhichColor.GreenOne);
                CanPlace = true;
            }
        }
    }

    public void EnabledTrigger()
    {
        foreach (var item in CornerTriggers)
        {
            item.EnabledTrigger();
        }
    }

    public void DisabledTrigger()
    {
        foreach (var item in CornerTriggers)
        {
            item.DisabledTrigger();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //DisabledTrigger();
        BuildSetPos.Instance.SetPosition(Parent, GridInfo.Instance.GetClosestGrid(DragManager.Instance.Build), _TriggerControl, OffsetX, OffsetY);
    }
    //public void EnableDetect
}
