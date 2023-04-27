using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PowerPlant : EnergyProduct, IProduct
{

    public void Damage(int value)
    {
        HealthValue -= value;
        if (HealthValue <= 0)
        {
            Die();   
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
