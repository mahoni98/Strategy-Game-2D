using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Barracks : MilitaryProduct, IProduct, IPointerDownHandler
{
    public Transform RandomPos;
    private void Start()
    {

    }
    
    public void Die()
    {
        throw new NotImplementedException();
    }

    public void Damage()
    {
        throw new NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SoldierMoveManager.Instance.MoveForAttack(transform);
    }
}
