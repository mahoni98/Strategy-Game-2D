using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ParentTriggerControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPortable
{
    [Header("Scripts")]
    [SerializeField] private CornerTrigger[] _CornerTriggers;
    [SerializeField] private DragColorControl _DragColorControl;
    [SerializeField] private TriggerControl _TriggerControl;


    [Header("Unity Variable")]
    [SerializeField] public Transform BuildParent;
    [SerializeField] private Transform Build;


    [Header("Basic Variable")]
    [SerializeField] private bool CanPlace;
    [SerializeField] public float OffsetX;
    [SerializeField] public float OffsetY;

    private void Start()
    {
        _CornerTriggers = transform.GetComponentsInChildren<CornerTrigger>();
        _DragColorControl = GetComponent<DragColorControl>();
        _TriggerControl = GetComponent<TriggerControl>();

        Build = transform;
        BuildParent = transform.parent;

        DisabledTrigger();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        InvokeRepeating("CheckTrigger", 0.2f, 0.2f);
        EnabledTrigger();
    }
    public void CheckTrigger()
    {
        //foreach (var item in _CornerTriggers)
        //{
        //    if (item.GridEmpt == false)
        //    {
        //        CanPlace = false;
        //        _DragColorControl.SetColor(DragColorControl.WhichColor.RedOne);
        //        return;
        //    }
        //    else
        //    {
        //        _DragColorControl.SetColor(DragColorControl.WhichColor.GreenOne);
        //        CanPlace = true;
        //    }
        //}
    }

    public void EnabledTrigger()
    {
        foreach (var item in _CornerTriggers)
        {
            item.EnabledTrigger();
        }
    }

    public IEnumerator DisabledTrigger()
    {
        CancelInvoke("CheckTrigger");
        foreach (var item in _CornerTriggers)
        {
            StartCoroutine(item.DisabledTrigger());
        }
        yield return new WaitForSeconds(0.4f);
        //_DragColorControl.SetColor(DragColorControl.WhichColor.Default);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        DragManager.Instance.Entry = false;
        DragManager.Instance.Build = null;
        if (CanPlace)
        {
            StartCoroutine(DisabledTrigger());
            _DragColorControl.SetColor(DragColorControl.WhichColor.Default);
            //BuildSetPos.Instance.SetPosition(Build, BuildParent, GridInfo.Instance.GetClosestGrid(DragManager.Instance.Build), _TriggerControl, OffsetX, OffsetY);
        }
    }
}
