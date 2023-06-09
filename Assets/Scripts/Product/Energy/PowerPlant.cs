﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PowerPlant : EnergyProduct, IProduct
{
    [SerializeField] private Slider _Slider;
    public void TakeDamage(int value)
    {
        HealthValue -= value;
        _Slider.value -= (value / 100f);
        if (HealthValue <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
        AstarPath.active.Scan();
    }
}
