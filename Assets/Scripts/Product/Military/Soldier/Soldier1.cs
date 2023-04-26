
using UnityEngine;
using DG.Tweening;
public class Soldier1 : Soldier, IProduct
{
    public ObjectPool ArrowPool;

    private void Start()
    {
        //ActiveAttack = true;
        //InvokeRepeating("Attack", AttackRateTime, AttackRateTime);
        //Attack();
        GoToEmptyGrid();
    }
    private void Update()
    {

    }

    public override void Attack()
    {
        if (ActiveAttack)
        {
            GameObject arrowObj = ArrowPool.GetObject();
            arrowObj.transform.position = transform.position;
            arrowObj.transform.rotation = transform.rotation;
            arrowObj.GetComponent<Arrow>().GoTarget(AttackRateTime);
            arrowObj.SetActive(true);
        }
        else
        {

        }
    }
    public void GoToEmptyGrid()
    {
        transform.parent.transform.DOMove(GridInfo.Instance.GetClosestGrid(transform).position, 0.5f);
    }
    public void Die()
    {
        throw new System.NotImplementedException();
    }
    void IProduct.Damage()
    {
        throw new System.NotImplementedException();
    }
}
