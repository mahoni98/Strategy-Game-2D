using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyHelper;

public class SoldiersAttackCheck : SingletonManager<SoldiersAttackCheck>
{
    public Soldier[] SoldierParents;
    Helper h = new Helper();
    private void Update()
    {

    }

    public void SoldierActiveAttackControl()
    {
        SoldierParents = FindObjectsOfType<Soldier>();
        foreach (var item in SoldierParents)
        {
            if (item.SoldierState == Soldier.State.Attack)
            {
                return;
            }
        }
        GameManager.Instance.UpdateState(GameState.RunGame);
    }
}
