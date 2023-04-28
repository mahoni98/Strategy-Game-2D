using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class SoldierMoveManager : SingletonManager<SoldierMoveManager>
{
    private AIControl CurrentSoldierAI;
    [SerializeField] private CreateTarget _CreateTarget;
    private bool SoldierSelected = false;

    public AIControl _CurrentSoldierAI { get => CurrentSoldierAI; set => CurrentSoldierAI = value; }

    private void OnEnable()
    {
        GameManager.onStateChanged += StateChange;
    }
    private void StateChange(GameState State)
    {
        switch (State)
        {
            case GameState.BuildPlacement:
                _CurrentSoldierAI = null;
                break;
            case GameState.RunGame:
                break;
        }
    }
    public void BeMove(Transform GridTransform)
    {
        Soldier SoldierBase = _CurrentSoldierAI.Soldier;

        if (SoldierSelected && SoldierBase.SoldierState != Soldier.State.Attack)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = GridTransform.position;
            _CurrentSoldierAI.Move(Target);
            _CurrentSoldierAI._AIPath.endReachedDistance = 0;
        }

    }
    public void MoveForAttack(Transform TransforForAttack)
    {
        if (PopUpControl.Instance.PlacemenentControl() == false) return;

        Soldier SoldierBase = _CurrentSoldierAI.Soldier;


        if (SoldierSelected && SoldierBase.SoldierState != Soldier.State.Attack)
        {
            Transform Target = _CreateTarget.Create();
            Target.position = TransforForAttack.position;
            _CurrentSoldierAI.Move(Target);
            _CurrentSoldierAI._AIPath.endReachedDistance = SoldierBase.AttackDistance;
            _CurrentSoldierAI.Soldier.TargetForAttack = TransforForAttack;
            _CurrentSoldierAI = null;
        }
    }

    public void ChooseSoldier(AIControl Soldier)
    {

        if (PopUpControl.Instance.PlacemenentControl() == false) return;
        _CurrentSoldierAI = Soldier;
        SoldierSelected = true;
    }
}

