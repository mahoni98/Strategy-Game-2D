using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Barracks : MilitaryProduct, IProduct
{
    public Transform RandomPos;
    
    public void Die()
    {
        Destroy(gameObject);
    }

    public void Damage(int value)
    {
        HealthValue -= value;
        if (HealthValue <= 0)
        {
            Die();
        }
    }
}
