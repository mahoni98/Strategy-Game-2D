using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SoldierMove : MonoBehaviour, IPointerDownHandler
{
    private int ChooseCount;
    public void OnPointerDown(PointerEventData eventData)
    {
        ChooseCount++;
        if (ChooseCount == 2)
        {

        }
    }
    public void Move()
    {

    }
}
