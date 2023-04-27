
using UnityEngine;
using DG.Tweening;
using System.Collections;
public class Soldier1 : Soldier, IProduct
{
    [SerializeField] private AIControl _AIControl;
    public ObjectPool ArrowPool;

    private void Start()
    {
        UpdateState(State.Idle);
        SetAIValues();
        GoToEmptyGrid();
    }
    private void Update()
    {
        if (_AIControl._AIPath.reachedDestination == true /*&& TargetForAttack != null*/ && JustOneEntry&&_AIControl._AIDestinationSetter.target!=null)
        {
            UpdateState(State.Attack);
        }
    }
    public void UpdateState(State State)
    {
        switch (State)
        {
            case State.Attack:
                SoldierState = State;
                JustOneEntry = false;
                StartCoroutine(Attack());
                GameManager.Instance.UpdateState(GameState.ThereIsSomeAttack);
                break;
            case State.Die:
                SoldierState = State;
                break;
            case State.Idle:
                SoldierState = State;
                JustOneEntry = true;
                GameManager.Instance.UpdateState(GameState.RunGame);
                break;
            default:
                break;
        }
    }
    public override IEnumerator Attack()
    {
        if (SoldierState == State.Attack)
        {
            if (TargetForAttack != null)
            {
                GameObject arrowObj = ArrowPool.GetObject();
                arrowObj.transform.position = transform.position;
                arrowObj.transform.rotation = transform.rotation;
                arrowObj.GetComponent<Arrow>().GoTarget(TargetForAttack, AttackRateTime);
                arrowObj.SetActive(true);
            }
            else
            {
                UpdateState(State.Idle);
                //SoldierMoveManager.Instance._CurrentSoldierAI = null;
            }

            yield return new WaitForSeconds(AttackRateTime);
            StartCoroutine(Attack());
        }
    }
    private void SetAIValues()
    {
        _AIControl._AIPath.maxSpeed = MoveSpeed;
    }
    public void GoToEmptyGrid()
    {
        Transform Closest = GridInfo.Instance.GetClosestGrid(transform);
        GridElement _GridELement = Closest.GetComponent<GridElement>();
        transform.parent.transform.DOMove(Closest.position, 0.5f);
        _GridELement.ThereAreSomething = true;
    }
    public void Die()
    {
        throw new System.NotImplementedException();
    }
    void IProduct.Damage(int value)
    {
        throw new System.NotImplementedException();
    }

}
