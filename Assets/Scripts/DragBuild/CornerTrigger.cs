using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CornerTrigger : MonoBehaviour, IBuild
{
    public bool GridEmpt = true;
    private BoxCollider2D Collider;

    private void Start()
    {
        Collider = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        GridElement _GridElement = collision.GetComponent<GridElement>();
        if (_GridElement != null && _GridElement.ThereAreSomething == false)
        {
            GridEmpt = true;
            return;
        }
        GridEmpt = false;
    }
    public void EnabledTrigger()
    {
        Collider.enabled = true;
    }
    public void DisabledTrigger()
    {
        Collider.enabled = false;
    }
}
