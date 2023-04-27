using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CornerTrigger : MonoBehaviour, IPortable
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
        if (_GridElement != null)
        {
            if (_GridElement.ThereAreSomething == false)
            {
                GridEmpt = true;
                return;
            }
            GridEmpt = false;
        }
    }
    public void EnabledTrigger()
    {
        Collider.enabled = true;
    }
    public IEnumerator DisabledTrigger()
    {
        Collider.enabled = false;
        yield return new WaitForSeconds(0f);
    }
}
