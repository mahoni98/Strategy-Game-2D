using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Arrow : MonoBehaviour
{
    //public GameObject Prefabs;
    public Transform Target;
    //public float speed = 10f;
    //public float duration = 1f;
    public Ease AnimType;
    //private Transform target;

    private void Start()
    {

    }

    private void Update()
    {
        //if (Target != null)
        //{
        //    transform.LookAt(Target);
        //}
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void GoTarget(float AttackSpeed)
    {
        Target = GameObject.FindGameObjectWithTag("Target").transform;
        transform.DOJump(Target.position,1f,1, AttackSpeed).SetEase(AnimType).OnComplete(OnHitTarget);
    }
    private void OnHitTarget()
    {
        gameObject.SetActive(false);
    }
}
