using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class SoldierMoveManager : SingletonManager<SoldierMoveManager>
{
    private AIControl CurrentSoldier;
    [SerializeField] private CreateTarget _CreateTarget;
    //private int TouchCount;
    private bool SoldierSelected = false;
    //public Transform Target;

    private void Update()
    {
        //Debug.Log("Seçili asker = " + CurrentSoldier);
        //if (Input.GetMouseButtonDown(0))
        //{

        //    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        //    //if(hit.)
        //    if (hit.collider != null)
        //    {

        //    }
        //}
    }
    // ulaþtýðýnda currentsoldier = null yapcaz.
    public void BeMove(Transform GridTransform)
    {
        if (SoldierSelected)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = GridTransform.position;
            CurrentSoldier.Move(Target);
            //SoldierSelected = false;
            //CurrentSoldier = null;
        }
    }
    public void ChooseSoldier(AIControl Soldier)
    {
        if (!SoldierSelected)
        {
          
        }
        CurrentSoldier = Soldier;
        SoldierSelected = true;
        Debug.Log("asker seçildi");
    }
}

