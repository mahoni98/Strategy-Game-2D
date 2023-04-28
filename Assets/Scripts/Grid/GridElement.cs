using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class GridElement : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    [SerializeField] private bool _ThereAreSomething = false;
    [SerializeField] private string _PlacedBuildName;

    public bool ThereAreSomething { get => _ThereAreSomething; set => _ThereAreSomething = value; }
    public string PlacedBuildName { get => _PlacedBuildName; set => _PlacedBuildName = value; }

    public bool ExitBuild(string Name)
    {

        if (_PlacedBuildName == Name)
        {
            WhenGridAction("");
            ThereAreSomething = false;
            return true;
        }
        return false;
    }
    public void EnterBuild(string Name)
    {
        if (_PlacedBuildName == "")
            WhenGridAction(Name);
    }
    public void WhenGridAction(string Name)
    {
        _PlacedBuildName = Name;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ThereAreSomething == false)
            SoldierMoveManager.Instance.BeMove(transform);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (DragManager.Instance.Entry && DragManager.Instance.Build != null)
        {
            //ParentTriggerControl _ParentTriggerControl = DragManager.Instance.Build.transform.parent.GetComponent<ParentTriggerControl>();
            TriggerControl _TriggerControl = DragManager.Instance.Build.transform.parent.GetComponent<TriggerControl>();
            BuildSetPos.Instance.SetPosition(DragManager.Instance.Build, _TriggerControl.BuildParent, transform, _TriggerControl, _TriggerControl.OffsetX, _TriggerControl.OffsetY);
        }
    }
}
