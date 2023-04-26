using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class SoldierMoveManager : SingletonManager<SoldierMoveManager>
{
    private AIControl CurrentSoldierAI;
    [SerializeField] private CreateTarget _CreateTarget;
    private bool SoldierSelected = false;

    private void Update()
    {
      
    }


    // ula�t���nda currentsoldier = null yapcaz.
    public void BeMove(Transform GridTransform)
    {
        if (SoldierSelected)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = GridTransform.position;
            CurrentSoldierAI.Move(Target);
            CurrentSoldierAI._AIPath.endReachedDistance = 0;
            //SoldierSelected = false;
            //CurrentSoldier = null;
        }
    }
    public void MoveForAttack(Transform TransforForAttack)
    {
        if (SoldierSelected)
        {
            Soldier SoldierBase = CurrentSoldierAI.GetComponent<Soldier>();
            Transform Target = _CreateTarget.Create();
            Target.position = TransforForAttack.position;
            CurrentSoldierAI.Move(Target);
            CurrentSoldierAI._AIPath.endReachedDistance = SoldierBase.AttackDistance;
            CurrentSoldierAI.Soldier.TargetForAttack = TransforForAttack;
            //SoldierSelected = false;
            //CurrentSoldier = null;
        }
    }
    public void ChooseSoldier(AIControl Soldier)
    {
        if (!SoldierSelected)
        {
          
        }
        CurrentSoldierAI = Soldier;
        SoldierSelected = true;
        Debug.Log("asker se�ildi");
    }
}

