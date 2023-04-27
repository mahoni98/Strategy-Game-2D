using UnityEngine;
using System.Collections;
public abstract class Soldier : MonoBehaviour
{
    public string Name;
    public string Info;
    public Sprite Image;
    public float AttackRateTime;
    public float AttackDistance;
    public float Damage;
    public float MoveSpeed;
    public Transform TargetForAttack;
    public bool JustOneEntry = true;
    public State SoldierState;
    public abstract IEnumerator Attack();
    public enum State
    {
        Attack , 
        Die,
        Idle,
    }
}
