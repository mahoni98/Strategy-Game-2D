using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.EventSystems;

public class AIControl : MonoBehaviour , IPointerDownHandler
{
    public AIPath _AIPath;
    public AIDestinationSetter _AIDestinationSetter;

    private void Start()
    {
        _AIPath = GetComponent<AIPath>();
        _AIDestinationSetter = GetComponent<AIDestinationSetter>();
        StopWalk();
    }
    public void StopWalk()
    {
        _AIPath.canMove = false;
        // yeni gidilcek y�n verilir. 

    }
    public void Move(Transform Target)
    {
        _AIPath.canMove = true;
        _AIDestinationSetter.target = Target;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SoldierMoveManager.Instance.ChooseSoldier(GetComponent<AIControl>());
    }
}