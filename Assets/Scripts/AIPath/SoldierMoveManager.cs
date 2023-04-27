using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class SoldierMoveManager : SingletonManager<SoldierMoveManager>
{
    private AIControl CurrentSoldierAI;
    [SerializeField] private CreateTarget _CreateTarget;
    private bool SoldierSelected = false;

    private void OnEnable()
    {
        GameManager.onStateChanged += StateChange;
    }
    private void StateChange(GameState State)
    {
        switch (State)
        {
            case GameState.BuildPlacement:
                CurrentSoldierAI = null;
                break;
            case GameState.Run:
                break;
        }
    }
    public void BeMove(Transform GridTransform)
    {
        Soldier SoldierBase = CurrentSoldierAI.Soldier;

        if (SoldierSelected && SoldierBase.SoldierState != Soldier.State.Attack)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = GridTransform.position;
            CurrentSoldierAI.Move(Target);
            CurrentSoldierAI._AIPath.endReachedDistance = 0;
        }
    }
    public void MoveForAttack(Transform TransforForAttack)
    {
        Soldier SoldierBase = CurrentSoldierAI.Soldier;

        if (SoldierSelected && SoldierBase.SoldierState != Soldier.State.Attack)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = TransforForAttack.position;
            CurrentSoldierAI.Move(Target);
            CurrentSoldierAI._AIPath.endReachedDistance = SoldierBase.AttackDistance;
            CurrentSoldierAI.Soldier.TargetForAttack = TransforForAttack;
            CurrentSoldierAI = null;
        }
    }

    public void ChooseSoldier(AIControl Soldier)
    {
        CurrentSoldierAI = Soldier;
        SoldierSelected = true;
    }
}

