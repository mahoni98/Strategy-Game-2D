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

    [SerializeField] private Slider _Slider;

    public void Die()
    {
        AstarPath.active.Scan();
        Destroy(gameObject);
    }

    public void Damage(int value)
    {
        HealthValue -= value;
        _Slider.value -= (value / 100f);
        if (HealthValue <= 0)
        {
            Die();
        }
    }
}
