using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    [SerializeField] private DragColorControl _DragColorControl;

    private bool AnyTriggerBusyGrid = false; // does it have any contact with the full grid

    private void Start()
    {
        _DragColorControl = GetComponent<DragColorControl>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid.ThereAreSomething == false&& AnyTriggerBusyGrid ==false)
        {
            //Grid.ThereAreSomething = true;
            _DragColorControl.SetColor(DragColorControl.WhichColor.GreenOne);
        }
        else
        {
            AnyTriggerBusyGrid = true;
            _DragColorControl.SetColor(DragColorControl.WhichColor.RedOne);
        }
    }
}
