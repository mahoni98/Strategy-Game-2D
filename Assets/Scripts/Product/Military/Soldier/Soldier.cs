﻿using UnityEngine;
public class Soldier : MonoBehaviour
{
    public string Name;
    public string Info;
    public Sprite Image;
    public float AttackSpeed;
    public float MoveSpeed;

    //public float ProductionCost;
    //public float RespawnTime;
    public virtual void Attack(/*GameObject target*/)
    {
        // Burada hedefe hasar verme kodu yer alır
    }

    public virtual void Move(/*Vector3 direction*/)
    {
        // Burada askerin yürüme kodu yer alır
    }

}