using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Arrow : MonoBehaviour
{
    public Ease AnimType;
    public void GoTarget(Transform Target,float AttackSpeed)
    {
        transform.DOJump(Target.position,1f,1, AttackSpeed).SetEase(AnimType).OnComplete(()=>OnHitTarget(Target));
    }
    private void OnHitTarget(Transform Target)
    {
        gameObject.SetActive(false);
        try
        {
            Target.parent.GetComponent<IProduct>().TakeDamage(10); // bu transforma barrack ekle scriptolarak 
        }
        catch (System.Exception ex)
        {
            
        }
    }
}
